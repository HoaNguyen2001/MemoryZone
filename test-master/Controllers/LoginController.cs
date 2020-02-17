using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//để sử dụng cho câu lệnh từ dòng 19
using System.Text;
using System.Security.Cryptography;
//để sử dụng models
using project_banhang.Models;
using Microsoft.AspNetCore.Http;

namespace project_banhang.Controllers
{
    public class LoginController : Controller
    {
        //khởi tạo đối tượng thao tác csdl
        private DataContext db = new DataContext();
        public IActionResult Index()
        {
            return View("_login");
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult LoginPost()
        {
            string _email = Request.Form["log"];
            string _password = Request.Form["pwd"];
            //mã hóa password
            _password = getHash(_password);
            //so sánh thông tin với csdl
            var record = db.users.Where(tbl => tbl.email == _email && tbl.password == _password).FirstOrDefault();
            if (record != null)
            {
                //đăng nhập thành công
                //sét biến session  để kiểm tra các trang trong admin
                HttpContext.Session.SetString("email", _email);
                return Redirect("/Admin/Home");
            }
            ViewBag.email = _email;
            return Redirect("/Login");
        }
        //hàm mã hóa từ text sang chuỗi SHA256
        private string getHash(string text)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}