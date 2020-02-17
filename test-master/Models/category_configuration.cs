using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project_banhang.Models
{
    public class category_configuration
    {
        [Key]
        public int id { get; set; }
        public int id_category { get; set; }
        public int id_subcategory { get; set; }
    }
}
