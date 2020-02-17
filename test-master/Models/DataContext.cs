using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using project_banhang.Models;

using Microsoft.EntityFrameworkCore;
//thao tac voi file config
using Microsoft.Extensions.Configuration;
//thao tac voi file
using System.IO;

namespace project_banhang.Models
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json");
            //var configuration = builder.Build();
            //optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
            optionsBuilder.UseSqlServer("Server=DESKTOP-PJN6I4S;Database=db_banhang;UID=sa;Password=Ta0lacuamay;");
        }
        // khởi tạo để sử dụng được các bảng trong sql
        public DbSet<users> users { get; set; }
        public DbSet<ItemsCategories> ItemsCategories { get; set; }
        public DbSet<ItemsList> ItemsList { get; set; }
        public DbSet<category_configuration> category_configuration { get; set; }
        public DbSet<items_configuration> items_configuration { get; set; }
        public DbSet<brand> brand { get; set; }
        public DbSet<order> order { get; set; }
        public DbSet<order_detail> order_detail { get; set; }
        public DbSet<customers> customers { get; set; }

    }
}
