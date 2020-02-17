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
//su dung cho IFormFile
using Microsoft.AspNetCore.Http;

namespace project_banhang.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        //khởi tạo đối tượng csdl
        private DataContext db = new DataContext();
        public IActionResult Index(int? page)
        {
            //---
            //quy dinh so ban ghi tren mot trang
            int pageSize = 5;
            //kiem tra neu co bien page truyen vao thi lay no
            //con khong thi lay gia tri 1
            int pageNumber = page.HasValue ? Convert.ToInt32(page) : 1;
            //lay cac ban ghi, sap xep theo id giam dan
            var list_record = db.order.OrderByDescending(tbl => tbl.id).ToList();
            return View("Index", list_record.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult Detail(int? page)
        {
            //---
            //quy dinh so ban ghi tren mot trang
            int pageSize = 5;
            //kiem tra neu co bien page truyen vao thi lay no
            //con khong thi lay gia tri 1
            int pageNumber = page.HasValue ? Convert.ToInt32(page) : 1;
            //lấy biến id truyền từ url
            int _id = int.Parse(Request.Query["id"]);
            var list_record = db.order_detail.Where(tbl => tbl.id_order == _id);
            return View("Detail", list_record.ToPagedList(pageNumber, pageSize));
            //return Content("hihi");
        }

        public IActionResult Comfirm()
        {
            int _id = Convert.ToInt32(HttpContext.Request.Query["id"]);
            var _list = db.order.Where(tbl => tbl.id == _id).FirstOrDefault();
            _list.status = true;
            _list.status_payment = "Đã thanh toán";
            db.SaveChanges();
            //return Content(_id.ToString());
            return Redirect("/Admin/Order/");
        }
    }
}