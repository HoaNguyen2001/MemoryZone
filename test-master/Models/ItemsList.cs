using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace project_banhang.Models
{
    public class ItemsList
    {
        [Key]
        public int id { get; set; }
        public int id_category { get; set; }
        public string media { get; set; }
        public string name { get; set; }
        public DateTime published { get; set; }
        public string content { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public bool sale { get; set; }
        public bool hot { get; set; }
        public double discount { get; set; }
        public string note { get; set; }
        public int id_brand { get; set; }
        public int storage { get; set; }
        public int busram { get; set; }
        public string chuanocung { get; set; }
    }
}
