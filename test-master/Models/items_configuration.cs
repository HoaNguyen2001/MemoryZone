using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project_banhang.Models
{
    public class items_configuration
    {
        [Key]
        public int id { get; set; }
        public int id_items { get; set; }
        public string storage { get; set; }
        public string brand { get; set; }
    }
}
