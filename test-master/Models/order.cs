using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project_banhang.Models
{
    public class order
    {
        [Key]
        public int id { get; set; }
        public int id_customer { get; set; }
        public DateTime created { get; set; }
        public double price { get; set; }
        public bool status { get; set; }
        public string status_payment { get; set; }
        public string address { get; set; }
        public string note { get; set; }
    }
}
