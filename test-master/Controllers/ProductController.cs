using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//su dung cac class ben trong thu muc Models
using project_banhang.Models;
//phan trang
using X.PagedList;
//thao tac voi file
using System.IO;
//su dung cho IFormFile
using Microsoft.AspNetCore.Http;

namespace project_banhang.Controllers
{
    public class ProductController : Controller
    {
        private DataContext db = new DataContext();
        [Route("/Product/Category/{id}")]
        public IActionResult Category(int? page,int id)
        {
            var _id = int.Parse(id.ToString());
            ViewBag.id=_id;
            //---
            //quy dinh so ban ghi tren mot trang
            int pageSize = 12;
            //kiem tra neu co bien page truyen vao thi lay no
            //con khong thi lay gia tri 1
            int pageNumber = page.HasValue ? Convert.ToInt32(page) : 1;

            //chỗ này để xử lý sắp xếp
            //lấy biến group truyền từ url
            string _group = HttpContext.Request.Query["group"];
            string _view = HttpContext.Request.Query["view"];

            //chỗ này xử lý tìm kiếm theo giá
            string _start = HttpContext.Request.Query["start"];
            string _stop = HttpContext.Request.Query["stop"];

            //tìm kiếm theo hãng
            string _brand = HttpContext.Request.Query["brand"];

            //lọc theo dung lượng
            string _storage = HttpContext.Request.Query["storage"];
            //var _tu = 0;
            //int _den = 0;

            //lọc theo chuẩn ổ cứng
            string _chuanocung= HttpContext.Request.Query["chuanocung"];

            //lọc theo bus ram
            string _busram = HttpContext.Request.Query["busram"];


            var list_record = db.ItemsList.Where(tbl=>tbl.id_category==_id).ToList().OrderByDescending(tbl=>tbl.id);//mặc định là xếp theo sản phẩm mới nhất
            if (_group != null && _group == "asc")
            {
                list_record = db.ItemsList.Where(tbl => tbl.id_category == _id).ToList().OrderBy(tbl => tbl.name);
            }

            if (_group != null && _group == "desc")
            {
                list_record = db.ItemsList.Where(tbl => tbl.id_category == _id).ToList().OrderByDescending(tbl => tbl.name);
            }

            if (_group != null && _group == "priceAsc")
            {
                list_record = db.ItemsList.Where(tbl => tbl.id_category == _id).ToList().OrderBy(tbl => tbl.price);
            }

            if (_group != null && _group == "priceDesc")
            {
                list_record = db.ItemsList.Where(tbl => tbl.id_category == _id).ToList().OrderByDescending(tbl => tbl.price);
            }

            if (_group != null && _group == "productNew")
            {
                list_record = db.ItemsList.Where(tbl => tbl.id_category == _id).ToList().OrderByDescending(tbl => tbl.published);
            }

            if (_group != null && _group == "productOld")
            {
                list_record = db.ItemsList.Where(tbl => tbl.id_category == _id).ToList().OrderBy(tbl => tbl.published);
            }

            if(_start!=null && _stop != null)
            {
                list_record = db.ItemsList.Where(tbl => tbl.id_category == _id && tbl.price>=Convert.ToDouble(_start) && tbl.price <= Convert.ToDouble(_stop)).ToList().OrderByDescending(tbl => tbl.id);
            }

            if (_brand != null)
            {
                var _id_brand = db.brand.Where(tbl => tbl.name.Contains(_brand)).FirstOrDefault().id;
                list_record = db.ItemsList.Where(tbl => tbl.id_category == _id && tbl.id_brand == _id_brand).ToList().OrderByDescending(tbl => tbl.id);
            }

            if (_storage != null)
            {
                //for (var i = 0; i < _storage.Length; i++)
                //{
                //    if (_storage[i] == 'G' || _storage[i] == 'g' || _storage[i] == 'T' || _storage[i] == 't')
                //    {
                //        int test1 = _storage.IndexOf("("); //lấy vị trí kí tự ( đầu trong chuỗi
                //        int test2 = _storage.LastIndexOf(" "); //lấy vị trí kí tự ) cuối trong chuỗi
                //        _tu = int.Parse(_storage.Substring(test1 + 1, i - 1));
                //        _den = int.Parse(_storage.Substring(test2 + 1, i - 1));
                //        break;
                //    }
                //}
                string[] test4 = _storage.Split("→");
                var _tu = test4[0].Substring(test4[0].IndexOf("(") + 1, test4[0].LastIndexOf("G") - 1);
                var _den = test4[1].Substring(test4[0].IndexOf("(") + 1, test4[1].LastIndexOf("G") - 1);
                list_record = db.ItemsList.Where(tbl => tbl.storage >= int.Parse(_tu) && tbl.storage <= int.Parse(_den) && tbl.id_category == _id).ToList().OrderByDescending(tbl=>tbl.id);
            }
            if (_chuanocung != null )
            {
                //_chuanocung = _chuanocung.Substring(_chuanocung.IndexOf("(") + 1, _chuanocung.LastIndexOf(")") - 1);
                list_record = db.ItemsList.Where(tbl => tbl.chuanocung.Contains(_chuanocung) && tbl.id_category==_id).ToList().OrderByDescending(tbl => tbl.id);
            }

            if (_busram != null)
            {
                list_record = db.ItemsList.Where(tbl => tbl.busram == int.Parse(_busram) && tbl.id_category == _id).ToList().OrderByDescending(tbl => tbl.id);
            }

            ViewBag.brand = db.brand.ToList();
            ViewBag.name = db.ItemsCategories.Where(tbl => tbl.id == db.ItemsList.Where(tbl1=>tbl1.id_category==_id).FirstOrDefault().id_category).FirstOrDefault();
            return View("Category", list_record.ToPagedList(pageNumber, pageSize));
            //return RedirectToAction("Category", "Product");
            //return Content(_tu.ToString());
            }
        [Route("/Product/Detail/{id}")]
        public IActionResult Detail(int id)
        {
            var _id = int.Parse(id.ToString());
            ViewBag._id = _id;
            ViewBag.id = db.ItemsList.Where(tbl => tbl.id == _id).FirstOrDefault().id_category;
            //lấy bản ghi tương ứng với id truyền từ url
            var list_record = db.ItemsList.Where(tbl => tbl.id == _id).FirstOrDefault();
            ViewBag.list_record = db.ItemsList.Where(tbl => tbl.id_category == list_record.id_category).ToList().Take(5).OrderByDescending(tbl=>tbl.id);
            if (list_record.id_brand == 0)
            {
                ViewBag.brand = "Không có thương hiệu";
            }
            else
            {
                ViewBag.brand = db.brand.Where(tbl => tbl.id == list_record.id_brand).FirstOrDefault().name;
            }
            
            return View("Detail",list_record);
            //return Content(_id);
        }
    }
}