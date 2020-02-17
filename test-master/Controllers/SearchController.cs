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
    public class SearchController : Controller
    {
        private DataContext db = new DataContext();

        public IActionResult Index(int? page)
        {
            //---
            //quy dinh so ban ghi tren mot trang
            int pageSize = 12;
            //kiem tra neu co bien page truyen vao thi lay no
            //con khong thi lay gia tri 1
            int pageNumber = page.HasValue ? Convert.ToInt32(page) : 1;

            //lấy biến truyền từ url
            ViewBag._query = HttpContext.Request.Query["query"].ToString();
            var _query = HttpContext.Request.Query["query"].ToString();

            //lấy bản ghi tương ứng với biến truyền từ url
            var list_record = db.ItemsList.Where(tbl => tbl.name.Contains(_query)).OrderByDescending(tbl => tbl.id).ToList();
            return View("Index", list_record.ToPagedList(pageNumber, pageSize));
            //return Content(list_record.FirstOrDefault().name);
        }
    }
}