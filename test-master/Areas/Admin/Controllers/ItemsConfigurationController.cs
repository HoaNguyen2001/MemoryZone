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

namespace project_banhang.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ItemsConfigurationController : Controller
    {
        DataContext db = new DataContext();
        //cấu hình sản phẩm
        [Route("/Admin/ItemsConfiguration/Configuration")]
        public IActionResult Configuration(int? page)
        {
            //---
            //quy dinh so ban ghi tren mot trang
            int pageSize = 5;
            //kiem tra neu co bien page truyen vao thi lay no
            //con khong thi lay gia tri 1
            int pageNumber = page.HasValue ? Convert.ToInt32(page) : 1;
            //lay cac ban ghi, sap xep theo id giam dan
            var list_record = db.items_configuration.OrderByDescending(tbl => tbl.id).ToList();
            ViewBag.nameProduct = db.ItemsList.Where(tbl => tbl.id == list_record.FirstOrDefault().id_items).FirstOrDefault();
            return View("Configuration", list_record.ToPagedList(pageNumber, pageSize));
        }

        //sửa
        public IActionResult Edit()
        {
            //lấy biến id truyền từ url
            int _id = int.Parse(Request.Query["id"]);
            //khai báo để chỉ dường dẫn của form đến editpost
            ViewBag.FormAction = "Admin/ItemsConfiguration/EditPost?id="+_id;
            //lấy 1 bản ghi tương ứng với id
            var record = db.items_configuration.Where(tbl => tbl.id == _id).FirstOrDefault();
            ViewBag.nameProduct = db.ItemsList.Where(tbl => tbl.id == record.id_items).FirstOrDefault();
            return View("editConfiguration", record);
        }
        //[HttpPost,ValidateAntiForgeryToken]
        //public IActionResult EditPost() {
        //    //khởi tạo đối tượng của class items_configuration
        //    var record = new items_configuration();

        //    //lấy bản ghi nhập từ form
        //    var _name = Request.Form["name"];
        //    var _brand = Request.Form["brand"];
        //    var _storage = Request.Form["storage"];

        //    record.
        //}

        //thêm
        public IActionResult Add()
        {
            //khai báo để chỉ dường dẫn của form đến editpost
            ViewBag.FormAction = "Admin/ItemsConfiguration/AddPost";
            return View("editConfiguration");
        }
        [HttpPost, ValidateAntiForgeryToken]
        //public IActionResult AddPost()
        //{

        //}

        //xóa
        public IActionResult Delete()
        {
            //lấy biến id truyền từ url
            int _id = int.Parse(Request.Query["id"]);
            //lấy 1 bản ghi tương ứng với id
            var record = db.items_configuration.Where(tbl => tbl.id == _id).FirstOrDefault();
            db.items_configuration.Remove(record);
            return RedirectToAction("Configuration", "ItemsConfiguration");
        }
    }
}