using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace project_banhang.Models
{
    public class ItemsCategories
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string thumnails { get; set; }
        public bool hot { get; set; }
        public bool showhome { get; set; }
    }
}
