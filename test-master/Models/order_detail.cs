using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project_banhang.Models
{
    public class order_detail
    {
        [Key]
        public int id { get; set; }
        public int id_order { get; set; }
        public int id_items { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    }
}
