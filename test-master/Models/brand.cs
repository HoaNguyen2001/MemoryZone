using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project_banhang.Models
{
    public class brand
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
