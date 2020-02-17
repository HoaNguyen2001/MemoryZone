using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace project_banhang.Models
{
    public class Cart
    {
        protected readonly DataContext db = new DataContext();
        //------
        public void SetObjectAsJson(ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public T GetObjectFromJson<T>(ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
        //------
        //lay gio hang dang ton tai
        public List<Item> GetCart(ISession session)
        {
            List<Item> cart = this.GetObjectFromJson<List<Item>>(session, "Cart");
            return cart;
        }
        //add item to cart
        public void CartAdd(ISession session, int id,int quantity)
        {
            if (this.GetObjectFromJson<List<Item>>(session, "Cart") == null)
            {
                List<Item> cart = new List<Item>();
                ItemsList item = db.ItemsList.Where(tbl => tbl.id == id).FirstOrDefault();
                if (item.sale)
                {
                    item.price = item.price - item.price * item.discount / 100;
                    cart.Add(new Item { ItemsList = item, quantity = quantity });
                }
                else
                {
                    cart.Add(new Item { ItemsList = item, quantity = quantity });
                }
                this.SetObjectAsJson(session, "Cart", cart);
            }
            else
            {
                List<Item> cart = this.GetObjectFromJson<List<Item>>(session, "Cart");

                int index = isExist(session,id);
                if (index != -1)
                {
                    cart[index].quantity++;
                }
                else
                {
                    ItemsList item = db.ItemsList.Where(tbl => tbl.id == id).FirstOrDefault();
                    if(quantity==null)
                    {
                        cart.Add(new Item { ItemsList = item, quantity = 1 });
                    }
                    else
                    {
                        cart.Add(new Item { ItemsList = item, quantity = quantity });
                    }
                }
                this.SetObjectAsJson(session, "Cart", cart);
            }
        }
        //remove item in cart
        public void CartRemove(ISession session, int id)
        {
            List<Item> cart = this.GetObjectFromJson<List<Item>>(session, "Cart");
            int index = isExist(session,id);
            cart.RemoveAt(index);
            this.SetObjectAsJson(session, "Cart", cart);
        }
        //remove all item in cart
        public void CartDestroy(ISession session)
        {
            List<Item> cart = new List<Item>();
            this.SetObjectAsJson(session, "Cart", cart);
        }
        public void CartUpdate(ISession session, int id, int quantity)
        {
            List<Item> cart = this.GetObjectFromJson<List<Item>>(session, "Cart");
            //---
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].ItemsList.id == id)
                {
                    cart[i].quantity = quantity;
                }
            }
            //---
            this.SetObjectAsJson(session, "Cart", cart);
        }
        private int isExist(ISession session, int id)
        {
            List<Item> cart = this.GetObjectFromJson<List<Item>>(session, "Cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].ItemsList.id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}