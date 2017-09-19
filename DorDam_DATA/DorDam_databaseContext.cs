using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;


namespace DorDam_DATA
{
    class DorDam_databaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sub_Category> Sub_Category { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Buying_History> Buying_History { get; set; }
        public DbSet<Product_Report> Product_Report { get; set; }
        public DbSet<User_Info> User_Info { get; set; }
        public DbSet<Log_in> Log_in { get; set; }
        public DbSet<Cart> Carts { get; set; }

    }
}
