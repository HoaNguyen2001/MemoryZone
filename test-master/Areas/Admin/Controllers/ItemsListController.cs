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

namespace project_banhang.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ItemsListController : Controller
    {
        //khởi tạo đối tượng csdl
        private DataContext db = new DataContext();
        public IActionResult List(int? page)
        {
            //---
            //quy dinh so ban ghi tren mot trang
            int pageSize = 12;
            //kiem tra neu co bien page truyen vao thi lay no
            //con khong thi lay gia tri 1
            int pageNumber = page.HasValue ? Convert.ToInt32(page) : 1;
            //lay cac ban ghi, sap xep theo id giam dan
            var list_record = db.ItemsList.OrderByDescending(tbl => tbl.id).ToList();
            ViewBag.brand = db.brand.OrderByDescending(tbl => tbl.id).ToList();
            return View("List", list_record.ToPagedList(pageNumber, pageSize));
        }

        //sửa sản phẩm sản phẩm
        public IActionResult Edit()
        {
            //lấy biến id truyền từ url
            int _id = int.Parse(Request.Query["id"]);
            //khai báo để chỉ dường dẫn của form đến editpost
            ViewBag.FormAction = "/Admin/ItemsList/Editpost?id=" + _id;
            //lấy 1 bản ghi
            var record = db.ItemsList.Where(tbl => tbl.id == _id).FirstOrDefault();
            ViewBag.brand1 = db.brand.ToList();
            return View("EditItemsList", record);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditPost(IFormFile media)
        {
            //lay bien id truyen tu url
            int _id = int.Parse(Request.Query["id"]);
            //var list = db.ItemsList.Where(tbl => tbl.id == _id).FirstOrDefault().name;
            //lay cac bien form control
            string _name = Request.Form["name"];
            string _content = Request.Form["content"];
            string _description = Request.Form["description"];
            string _id_category = Request.Form["id_category"];
            int _price = int.Parse(Request.Form["price"]);
            DateTime _pushlished = DateTime.Now;
            var _storage = Request.Form["storage"];
            var _hot = Request.Form["hot"] != "" && Request.Form["hot"] == "on" ? true : false;
            var _sale = Request.Form["sale"] != "" && Request.Form["sale"] == "on" ? true : false;
            double _discount = double.Parse(Request.Form["discount"]);
            string _note = Request.Form["note"];
            int _brand = int.Parse(Request.Form["brand"]);

            //lay mot ban ghi tuong ung voi id truyen vao
            var Record = db.ItemsList.Where(tbl => tbl.id == _id).FirstOrDefault();

            //---
            Record.name = _name;
            Record.content = _content;
            Record.description = _description;
            Record.id_category = int.Parse(_id_category);
            Record.price = _price;
            Record.published = _pushlished;
            Record.storage = int.Parse(_storage);
            Record.hot = _hot;
            Record.sale = _sale;
            Record.discount = _discount;
            Record.note = _note;
            Record.id_brand = _brand;

            //xử lí ảnh
            if (media != null)
            {
                //xoa anh cu
                if (Record.media != null && System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Products", Record.media)))
                {
                    //xoa anh
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Products", Record.media));
                }
                //upload anh moi
                string _fileName = media.FileName;
                //lay thoi gian gan vao ten file
                var timestamp = DateTime.Now.ToFileTime();
                _fileName = timestamp + "_" + _fileName;
                //lay duong dan cua file
                string _path = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Products", _fileName));
                //upload file
                using (var stream = new FileStream(_path, FileMode.Create))
                {
                    media.CopyTo(stream);
                }
                //update gia tri vao cot media trong csdl
                Record.media = _fileName;
            }
            //end xử lý ảnh

            //lưu vào csdl
            db.SaveChanges();
            return RedirectToAction("List", "ItemsList");
            //return Content(Record.media);
        }
        //thêm sản phẩm
        public IActionResult Add()
        {
            //khai báo để chỉ dường dẫn của form đến addpost
            ViewBag.FormAction = "/Admin/ItemsList/Addpost";
            ViewBag.brand1 = db.brand.ToList();
            return View("EditItemsList");
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddPost(IFormFile media)
        {
            //khởi tạo đối tượng của class ItemsList
            var Record = new ItemsList();
            //lấy các biến trong form trước
            string _name = Request.Form["name"];
            string _content = Request.Form["content"];
            string _description = Request.Form["description"];
            string _id_category = Request.Form["id_category"];
            int _price = int.Parse(Request.Form["price"]);
            DateTime _pushlished = DateTime.Now;
            var _hot = Request.Form["hot"] != "" && Request.Form["hot"] == "on" ? true : false;
            var _sale = Request.Form["sale"] != "" && Request.Form["sale"] == "on" ? true : false;
            var _discount = Request.Form["discount"];
            if (_discount == "") { _discount = "0"; };
            string _note = Request.Form["note"];
            int _brand = int.Parse(Request.Form["brand"]);

            //kiểm tra xem sản phẩm đã có chưa
            var check = db.ItemsList.Where(tbl => tbl.name == _name).FirstOrDefault();
            if (check == null)
            {
                //xử lí ảnh
                if (media != null)
                {
                    //xóa ảnh cũ
                    if (Record.media != null && System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Products", Record.media)))
                    {
                        //xóa ảnh
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Products", Record.media));
                    }
                    //upload anh moi
                    string _fileName = media.FileName;
                    //lay thoi gian gan vao ten file
                    var timestamp = DateTime.Now.ToFileTime();
                    _fileName = timestamp + "_" + _fileName;
                    //lay duong dan cua file
                    string _path = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Products", _fileName));
                    //upload file
                    using (var stream = new FileStream(_path, FileMode.Create))
                    {
                        media.CopyTo(stream);
                    }
                    //update gia tri vao cot media trong csdl
                    Record.media = _fileName;
                }
                //end xử lý ảnh
                Record.name = _name;
                Record.content = _content;
                Record.description = _description;
                Record.id_category = int.Parse(_id_category);
                Record.price = _price;
                Record.published = _pushlished;
                Record.hot = _hot;
                Record.sale = _sale;
                Record.discount = double.Parse(_discount);
                Record.note = _note;
                Record.id_brand = _brand;
                //lưu vào csdl
                db.ItemsList.Add(Record);
                db.SaveChanges();
                return RedirectToAction("List", "ItemsList");
            }
            else
                return Redirect("/Admin/ItemsList/Add?mode=exists");
            //return LocalRedirect("/Admin/ItemsList/Add?mode=exists");
        }

        //xóa sản phẩm
        public IActionResult Delete()
        {
            //lấy id truyền từ url
            int _id = int.Parse(Request.Query["id"]);
            //lấy bản ghi tương ứng với id truyền vào
            var Record = db.ItemsList.Where(tbl => tbl.id == _id).FirstOrDefault();
            if (Record.media != null && System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Products", Record.media)))
            {
                //xoa anh
                System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Products", Record.media));
            }
            db.ItemsList.Remove(Record);
            db.SaveChanges();
            return RedirectToAction("List", "ItemsList");
        }
    }
}