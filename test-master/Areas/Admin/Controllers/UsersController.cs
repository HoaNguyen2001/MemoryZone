using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//sử dụng các class bên trong models
using project_banhang.Models;
//phân trang
using X.PagedList;
//mã hóa password
using System.Security.Cryptography;
using System.Text;

namespace project_banhang.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private DataContext db = new DataContext();

        public IActionResult List(int? page)
        {
            int pageSize = 10;
            //kiểm tra nếu có biến page truyền vào thì lấy nó
            //còn không thì lấy giá trị 1
            int pageNumber = page.HasValue ? Convert.ToInt32(page) : 1;
            //lấy các bản ghi, sắp xếp theo id giảm dần
            var list_record = db.users.OrderByDescending(tbl => tbl.id).ToList();
            return View("List",list_record.ToPagedList(pageNumber,pageSize));
        }

        //sửa thông tin users
        public IActionResult edit()
        {
            //lấy biến _id truyền từ url
            int _id = int.Parse(Request.Query["id"]);
            //khai báo biến để chỉ action của form ! rất cần thiết
            ViewBag.FormAction = "/Admin/Users/EditPost?id=" + _id;
            //lấy 1 bản ghi
            var record = db.users.Where(tbl => tbl.id == _id).FirstOrDefault();
            return View("AddEditUser", record);
        }
        //khi ấn vào submid chứ năng edit
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditPost()
        {
            //lấy biến _id truyền từ url
            int _id = int.Parse(Request.Query["id"]);
            //lấy các biến form control
            string _name = Request.Form["name"];
            string _email = Request.Form["email"];
            string _pw = Request.Form["password"];
            //update bản ghi
            var record = db.users.Where(tbl => tbl.id == _id).FirstOrDefault();
            record.name = _name;
            record.email = _email;
            record.password = _pw;
            //nếu _pw không bằng rỗng thì update password
            if (!string.IsNullOrEmpty(_pw))
            {
                //mã hóa password
                _pw = getHash(_pw);
                record.password = _pw;
            }
            db.SaveChanges();
            //--
            return RedirectToAction("List", "Users");
        }
        //hàm mã hóa password
        private string getHash(string text)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        //thêm user
        public IActionResult Add()
        {
            //khai báo biến để chỉ action của form ! rất cần thiết
            ViewBag.FormAction = "/Admin/Users/AddPost";
            return View("AddEditUser");
        }
        //khi ấn nút submit để thêm bản gi
        public IActionResult AddPost()
        {
            //lấy các biến form control
            string _name = Request.Form["name"];
            string _email = Request.Form["email"];
            string _pw = Request.Form["password"];
            //mã hóa password
            _pw = getHash(_pw);
            // khởi tạo bản ghi
            var record = new users();

            //nếu email khác nhau thì mới đoực thêm
            record.name = _name;
            record.email = _email;
            record.password = _pw;
            db.users.Add(record);
            db.SaveChanges();
            return RedirectToAction("List", "Users");
        }
        //xóa user
        public IActionResult Delete()
        {
            //lấy biến _id truyền từ url
            int _id = int.Parse(Request.Query["id"]);
            var record = db.users.Where(tbl => tbl.id == _id).FirstOrDefault();
            db.users.Remove(record);
            db.SaveChanges();
            return RedirectToAction("List", "Users");
        }
    }
}