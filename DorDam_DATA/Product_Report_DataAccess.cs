using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    class Product_Report_DataAccess : iProduct_Report_DataAccess
    {
        private DorDam_databaseContext context;

        public Product_Report_DataAccess(DorDam_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product_Report> GetAllValues()
        {
            return this.context.Product_Report.ToList();
        }

        public Product_Report Get(int id)
        {
            return this.context.Product_Report.SingleOrDefault(x => x.Product_ID == id);
        }

        public int Insert(Product_Report product_report)
        {
            this.context.Product_Report.Add(product_report);
            return this.context.SaveChanges();
        }

        public int Update(Product_Report product_report)
        {
            Product_Report proRe = this.context.Product_Report.SingleOrDefault(x => x.Product_ID == product_report.Product_ID);
            proRe.Selling_Quantity = product_report.Selling_Quantity;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Product_Report proRE = this.context.Product_Report.SingleOrDefault(x => x.Product_ID == id);
            this.context.Product_Report.Remove(proRE);

            return this.context.SaveChanges();
        }

        public Product_Report report()
        {
            return this.context.Product_Report.OrderByDescending(x => x.Selling_Quantity).Take(1).SingleOrDefault();
        }
    }
}
