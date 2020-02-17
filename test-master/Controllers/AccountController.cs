using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using project_banhang.Models;
using System.Security.Cryptography;
using System.Text;
//su dung bien session phai khai bao doi tuong nay
using Microsoft.AspNetCore.Http;

namespace project_banhang.Controllers
{
    
    public class AccountController : Controller
    {
        protected DataContext db = new DataContext();

        [Route("/Account/")]
        public IActionResult Index()
        {
            var _infor_cart = db.order.Where(tbl => tbl.id_customer == int.Parse(HttpContext.Session.GetString("customer_id")));
            ViewBag.user = db.users.Where(tbl => tbl.id == int.Parse(HttpContext.Session.GetString("customer_id"))).FirstOrDefault().id;
            return View("Index",_infor_cart);
            //return Content(HttpContext.Session.GetString("customer_id"));
        }

        //đăng kí
        [Route("Account/Register")]
        public IActionResult Register()
        {
            return View("Register");
        }
        //co the ghi chung hoac tach ra cac thuoc tinh trong []
        [HttpPost, ValidateAntiForgeryToken, Route("/Account/RegisterPost")]
        public IActionResult RegisterPost()
        {
            string _lName = Request.Form["lastName"];//họ
            string _fName = Request.Form["firstName"];//tên
            string _name = _lName +" "+ _fName;
            string _email = Request.Form["email"];
            string _address = Request.Form["address"];
            string _phone = Request.Form["phone"];
            string _password = Request.Form["password"];
            //ma hoa password
            _password = getHash(_password);
            //---
            //kiem tra trong table customer xem email da ton tai chua, neu chua thi moi insert
            var check = db.customers.Where(tbl => tbl.email == _email).FirstOrDefault();
            if (check == null)
            {
                //insert ban ghi
                var record = new customers();
                record.name = _name;
                record.address = _address;
                record.phone = _phone;
                record.password = _password;
                record.email = _email;
                //---
                db.customers.Add(record);
                db.SaveChanges();
            }
            else
            {
                //neu email da ton tai
                return Redirect("/Account/Register?mode=exists");
            }
            //---
            return Redirect("/Account/Login/");
            //return Redirect("/Account/Register");
        }

        //đăng nhập
        public IActionResult Login()
        {
            return View("Login");
        }
        [Route("Account/LoginPost"), HttpPost, ValidateAntiForgeryToken]
        public IActionResult LoginPost()
        {
            string _email = Request.Form["email"];
            string _password = Request.Form["password"];
            //ma hoa password
            _password = getHash(_password);
            //kiem tra login
            var record = db.customers.Where(tbl => tbl.email == _email && tbl.password == _password).FirstOrDefault();
            if (record != null)
            {
                //dang nhap thanh cong
                //set bien session, phân biệt với account admin
                HttpContext.Session.SetString("customer_email", _email);
                HttpContext.Session.SetString("customer_id", record.id.ToString());
                return Redirect("/Account");
            }
            else
            {
                return Redirect("/Account/Login?mode=invalid");
            }
        }

        //đăng xuất
        [Route("Account/Logout")]
        public IActionResult Logout()
        {
            //huy session email
            HttpContext.Session.Remove("customer_email");
            return Redirect("/Home");
        }

        //hàm mã hóa mk
        private string getHash(string text)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }








        //địa chỉ
        [Route("/Account/Addresses")]
        public IActionResult Addresses()
        {
            //lấy id tương ứng với session
            string _customerid =HttpContext.Session.GetString("customer_id");
            string _customername = db.customers.Where(tbl => tbl.id == int.Parse(_customerid)).FirstOrDefault().name.Trim();
            ViewBag.user = db.customers.Where(tbl => tbl.id == int.Parse(_customerid)).FirstOrDefault().id;
            int pos = 0;
            for (int i = 0; i <= _customername.Length; i++)
                if (_customername[i] == ' ')
                {
                    pos = i;
                    break;
                }
            ViewBag.lname = _customername.Substring(pos+1); //lấy họ
            ViewBag.fname = _customername.Substring(0,pos); //lấy tên
            ViewBag._customername = db.customers.Where(tbl => tbl.id == int.Parse(_customerid)).FirstOrDefault();
            return View("Addresses");
            //return Content(_customername.Length.ToString());
        }
        [Route("/Account/AddressesPost/{id}")]
        public IActionResult AddressesPost()
        {
            //lấy dữ liệu từ form control
            var _firstName = Request.Form["FirstName"];
            var _lasttName = Request.Form["LastName"];
            var _address = Request.Form["Address1"];
            var _city = Request.Form["City"];
            var _country = Request.Form["Country"];
            var _phone = Request.Form["PhoneNumber"];

            //lấy data tương ứng với id của session
            var record = db.customers.Where(tbl => tbl.id == int.Parse(HttpContext.Session.GetString("customer_id"))).FirstOrDefault();

            //lưu vào db
            record.name = _firstName + " " + _lasttName;
            record.address = _address;
            record.phone = _phone;
            record.city = _city;
            record.country = _country;
            db.SaveChanges();
            return Redirect("/Account/Addresses");
           // return Content("hihi");
        }

    }
}