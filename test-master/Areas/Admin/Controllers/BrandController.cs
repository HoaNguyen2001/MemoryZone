using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project_banhang.Models;
using X.PagedList;

namespace project_banhang.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private DataContext db = new DataContext();
        [Route("/Admin/Brand/")]
        public IActionResult Index(int? page)
        {
            //---
            //quy dinh so ban ghi tren mot trang
            int pageSize = 5;
            //kiem tra neu co bien page truyen vao thi lay no
            //con khong thi lay gia tri 1
            int pageNumber = page.HasValue ? Convert.ToInt32(page) : 1;
            //lay cac ban ghi, sap xep theo id giam dan
            var list_record = db.brand.OrderByDescending(tbl => tbl.id).ToList();
            //return View("List", list_record.ToPagedList(pageNumber, pageSize));
            return View("Index", list_record.ToPagedList(pageNumber, pageSize));
        }

        //sửa
        public IActionResult Edit()
        {
            //lấy biến id truyền từ url
            int _id = int.Parse(Request.Query["id"]);
            //khai báo để chỉ dường dẫn của form đến editpost
            ViewBag.FormAction = "/Admin/Brand/Editpost?id=" + _id;
            //lấy 1 bản ghi
            var record = db.brand.Where(tbl => tbl.id == _id).FirstOrDefault();
            return View("EditBrand",record);
            //return Content("hihi");
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult EditPost()
        {
            //lay bien id truyen tu url
            int _id = int.Parse(Request.Query["id"]);
            var _name = Request.Form["brand"];
            //lấy 1 bản ghi tương ứng với id truyền vào
            var record = db.brand.Where(tbl => tbl.id == _id).FirstOrDefault();
            var check = db.brand.Where(tbl => tbl.name == _name).FirstOrDefault();
            if (check == null)
            {
                record.name = _name;
                db.SaveChanges();
            }
            else
            {
                ViewBag.thongbao = 0;
            }
            return RedirectToAction("Index", "Brand");
        }

        //thêm
        public IActionResult Add()
        {
            
            //khai báo để chỉ dường dẫn của form đến editpost
            ViewBag.FormAction = "/Admin/Brand/Addpost";
            
            return View("EditBrand");
            //return Content("hihi");
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddPost()
        {
            //lay bien id truyen tu url
            var _name = Request.Form["brand"];
            //lấy 1 bản ghi tương ứng với id truyền vào
            var record = new brand();
            var check = db.brand.Where(tbl => tbl.name == _name).FirstOrDefault();
            if (check == null)
            {
                record.name = _name;
                db.brand.Add(record);
                db.SaveChanges();
            }
            else
            {
                ViewBag.thongbao = 0;
            }
            return RedirectToAction("Index", "Brand");
        }
        //xóa
        public IActionResult Delete()
        {
            //lay bien id truyen tu url
            int _id = int.Parse(Request.Query["id"]);
            //lay mot ban ghi tuong ung voi id truyen vao
            var Record = db.brand.Where(tbl => tbl.id == _id).FirstOrDefault();
            //xoa ban ghi
            db.brand.Remove(Record);
            db.SaveChanges();
            return RedirectToAction("Index", "Brand");
        }
    }
}