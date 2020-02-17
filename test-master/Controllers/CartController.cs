using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using project_banhang.Models;
//su dung bien session phai khai bao doi tuong nay
using Microsoft.AspNetCore.Http;

namespace project_banhang.Controllers
{
    public class CartController : Controller
    {
        //khoi tao doi tuong gio hang
        Cart ShoppingCart = new Cart();
        //khoi tao doi tuong thao tac csdl
        DataContext db = new DataContext();
        public IActionResult Index()
        {
            //lay cac san pham trong gio hang
            List<Item> _cart = ShoppingCart.GetCart(HttpContext.Session);
            if (_cart != null)
            {
                ViewBag._cart = _cart;
                ViewBag._total = _cart.Sum(tbl => tbl.ItemsList.price*tbl.quantity);
                ViewBag.count = _cart.Count();
            }
            return View();
        }

        [Route("/Cart/Buy/{id}")]
        public IActionResult Buy(int id)
        {
            //goi ham CartAdd trong class Cart de them phan tu vao gio hang
            //lay so luong cua cac phan tu
            int quantity = int.Parse(Request.Form["quantity"]);
            ShoppingCart.CartAdd(HttpContext.Session, id,quantity);
            return RedirectToAction("Index", "Cart");
            //return Content(quantity.ToString());
        }

        [Route("/Cart/Remove/{id}")]
        public IActionResult Remove(int id)
        {
            //goi ham CartRemove trong class Cart de xoa phan tu khoi gio hang
            ShoppingCart.CartRemove(HttpContext.Session, id);
            //ShoppingCart.CartDestroy(HttpContext.Session);
            return RedirectToAction("Index", "Cart");
            //return Content();
        }

        [Route("/Cart/Checkout/")]
        public IActionResult Checkout()
        {
            //lay cac san pham trong gio hang
            List<Item> _cart = ShoppingCart.GetCart(HttpContext.Session);
            //kiem tra neu user chua dang nhap thi yeu cau dang nhap
            if (HttpContext.Session.GetString("customer_email") == null)
            {
                return Redirect("/Account/Login");
            }
            else
            {
                var _id = HttpContext.Session.GetString("customer_id");
                ViewBag.customer = db.customers.Where(tbl => tbl.id == int.Parse(_id)).FirstOrDefault(); //lấy thông tin session
                //ViewBag.order = db.order.Where(tbl => tbl.id_customer == int.Parse(_id)).ToList();
                ViewBag.fee = _cart.Sum(tbl => tbl.ItemsList.price * tbl.quantity); //đơn hàng trên 300k thì free ship
                ViewBag.count = _cart.Count(); //đếm số sản phẩm trong giỏ hàng
                ViewBag._cart = _cart; //lấy csac sản phẩm trong giỏ hàng
                ViewBag._total = _cart.Sum(tbl => tbl.ItemsList.price * tbl.quantity); //tổng tiền hàng trong giỏ hàng
                //ViewBag.order_detail = db.order_detail.ToList();
            }
            return View("Checkout");
        }


        [Route("/Cart/Order")]
        public IActionResult Order()
        {
            //kiem tra neu user chua dang nhap thi yeu cau dang nhap
            if (HttpContext.Session.GetString("customer_email") == null)
            {
                return Redirect("/Account/Login");
            }
            else
            {
                List<Item> _cart = ShoppingCart.GetCart(HttpContext.Session);
                //lay customer_id cua session
                int customer_id = int.Parse(HttpContext.Session.GetString("customer_id"));
                var _customer = db.customers.Where(tbl => tbl.id == customer_id).FirstOrDefault();
                //insert du lieu vao table orders
                order recordOrder = new order();
                recordOrder.id_customer = customer_id;
                recordOrder.created = DateTime.Now;
                recordOrder.price = _cart.Sum(tbl => tbl.ItemsList.price * tbl.quantity);
                recordOrder.address = _customer.address;
                recordOrder.status_payment = Request.Form["PaymentMethodId"];
                //recordOrder.status = "Đang giao hàng";
                db.order.Add(recordOrder);
                db.SaveChanges();
                //lay id vua insert
                int order_id = recordOrder.id;
                //duyet cac phan tu trong session, moi phan tu se add thanh 1 ban ghi trong orders_detail                
                foreach (var item in _cart)
                {
                    //insert du lieu vao table orders_detail
                    order_detail recordOrderDetail = new order_detail();
                    recordOrderDetail.id_order = order_id;
                    recordOrderDetail.id_items = item.ItemsList.id;
                    //if (item.ItemsList.sale == false)
                    //{
                        recordOrderDetail.price = item.ItemsList.price;
                    //}
                    //else
                    //{
                    //    recordOrderDetail.price = item.ItemsList.price - item.ItemsList.price*item.ItemsList.discount/100;
                    //}
                    recordOrderDetail.quantity = item.quantity;
                    //---
                    db.order_detail.Add(recordOrderDetail);
                    db.SaveChanges();
                }

                //xoa tat ca cac phan to trong gio hang
                ShoppingCart.CartDestroy(HttpContext.Session);
                //---
                return Redirect("/Cart?checkout=success");
                //return View("Checkout");
            }
        }
    }
}