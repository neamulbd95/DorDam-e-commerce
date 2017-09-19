using DorDam_ENTITY;
using DorDam_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    class Product_Report_Service : iProduct_Report_Service
    {
        private iProduct_Report_DataAccess data;

        public Product_Report_Service(iProduct_Report_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Product_Report> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public Product_Report Get(int id)
        {
            return this.data.Get(id);
        }
        public int Insert(Product_Report Product_Report)
        {
            return this.data.Insert(Product_Report);
        }
        public int Update(Product_Report Product_Report)
        {
            return this.data.Update(Product_Report);
        }
        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public Product_Report report()
        {
            return this.data.report();
        }
    }
}
