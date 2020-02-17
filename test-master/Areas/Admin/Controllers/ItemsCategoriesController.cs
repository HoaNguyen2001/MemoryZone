using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//su dung cac class ben trong thu muc Models
using project_banhang.Models;
//phan trang
using X.PagedList;



namespace project_banhang.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ItemsCategoriesController : Controller
    {
        private DataContext db = new DataContext();
        public IActionResult List(int? page)
        {
            //---
            //lay bien key truyen tu url
            string key = Request.Query["key"];
            if (key == null)
                key = "";
            //lay bien where truyen tu url
            string where = Request.Query["where"];
            //---
            //quy dinh so ban ghi tren mot trang
            int pageSize = 12;
            //kiem tra neu co bien page truyen vao thi lay no
            //con khong thi lay gia tri 1
            int pageNumber = page.HasValue ? Convert.ToInt32(page) : 1;
            //lay cac ban ghi, sap xep theo id giam dan
            var list_record = db.ItemsCategories.Where(tbl => tbl.name.Contains(key)).OrderByDescending(tbl => tbl.id).ToList();
            if (where != null && where == "equal")
            {
                list_record = db.ItemsCategories.Where(tbl => tbl.name.Equals(key)).OrderByDescending(tbl => tbl.id).ToList();
            }
            return View("List", list_record.ToPagedList(pageNumber, pageSize));
        }
        //sửa thông tin danh mục
        public IActionResult Edit()
        {
            //lay bien id truyen tu url
            int _id = int.Parse(Request.Query["id"]);
            //tao bien dieu phoi action cua form
            ViewBag.FormAction = "/Admin/ItemsCategories/EditPost?id=" + _id;
            //lay mot ban ghi tuong ung voi id truyen vao
            var Record = db.ItemsCategories.Where(tbl => tbl.id == _id).FirstOrDefault();
            return View("AddEditCategory", Record);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditPost(IFormFile thumnails)
        {
            //lay bien id truyen tu url
            int _id = int.Parse(Request.Query["id"]);

            //lay cac bien form control
            string _name = Request.Form["name"];
            var _hot = Request.Form["hot"] != "" && Request.Form["hot"] == "on" ? true : false;
            var _showhome = Request.Form["showhome"] != "" && Request.Form["showhome"] == "on" ? true : false;

            //lay mot ban ghi tuong ung voi id truyen vao
            var Record = db.ItemsCategories.Where(tbl => tbl.id == _id).FirstOrDefault();
            Record.name = _name;
            Record.hot = _hot;
            Record.showhome = _showhome;

            //xử lí ảnh
            if (thumnails != null)
            {
                //xoa anh cu
                if (Record.thumnails != null && System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Category-Thum", Record.thumnails)))
                {
                    //xoa anh
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Category-Thum", Record.thumnails));
                }
                //upload anh moi
                string _fileName = thumnails.FileName;
                //lay thoi gian gan vao ten file
                var timestamp = DateTime.Now.ToFileTime();
                _fileName = timestamp + "_" + _fileName;
                //lay duong dan cua file
                string _path = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Category-Thum", _fileName));
                //upload file
                using (var stream = new FileStream(_path, FileMode.Create))
                {
                    thumnails.CopyTo(stream);
                }
                //update gia tri vao cot thumnails trong csdl
                Record.thumnails = _fileName;
            }
            //end xử lý ảnh

            db.SaveChanges();
            return RedirectToAction("List", "ItemsCategories");
        }

        //thêm danh mục
        public IActionResult Add()
        {
            //tao bien dieu phoi action cua form
            ViewBag.FormAction = "/Admin/ItemsCategories/AddPost";
            return View("AddEditCategory");
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddPost(IFormFile thumnails)
        {
            //lay cac bien form control
            string _name = Request.Form["name"];
            var _hot = Request.Form["hot"] != "" && Request.Form["hot"] == "on" ? true : false;
            var _showhome = Request.Form["showhome"] != "" && Request.Form["showhome"] == "on" ? true : false;

            //tao object cua class categories
            var Record = new ItemsCategories();
            Record.name = _name;
            Record.hot = _hot;
            Record.showhome = _showhome;

            //xử lí ảnh
            if (thumnails != null)
            {
                //xoa anh cu
                if (Record.thumnails != null && System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Category-Thum", Record.thumnails)))
                {
                    //xoa anh
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Category-Thum", Record.thumnails));
                }
                //upload anh moi
                string _fileName = thumnails.FileName;
                //lay thoi gian gan vao ten file
                var timestamp = DateTime.Now.ToFileTime();
                _fileName = timestamp + "_" + _fileName;
                //lay duong dan cua file
                string _path = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Category-Thum", _fileName));
                //upload file
                using (var stream = new FileStream(_path, FileMode.Create))
                {
                    thumnails.CopyTo(stream);
                }
                //update gia tri vao cot thumnails trong csdl
                Record.thumnails = _fileName;
            }
            //end xử lý ảnh

            db.ItemsCategories.Add(Record);
            db.SaveChanges();
            return RedirectToAction("List", "ItemsCategories");
        }

        //xóa danh mục
        public IActionResult Delete()
        {
            //lay bien id truyen tu url
            int _id = int.Parse(Request.Query["id"]);
            //lay mot ban ghi tuong ung voi id truyen vao
            var Record = db.ItemsCategories.Where(tbl => tbl.id == _id).FirstOrDefault();

            if (Record.thumnails != null && System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Category-Thum", Record.thumnails)))
            {
                //xoa anh
                System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "Category-Thum", Record.thumnails));
            }
            //xoa ban ghi
            db.ItemsCategories.Remove(Record);
            db.SaveChanges();
            return RedirectToAction("List", "ItemsCategories");
        }
    }
}