using DorDam_ENTITY;
using DorDam_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    class Product_Service : iProduct_Service
    {
        private iProduct_DataAccess data;

        public Product_Service(iProduct_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Product> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public Product Get(int id)
        {
            return this.data.Get(id);
        }
        public Product GetLastItem(int id) 
        {
            return this.data.GetLastItem(id);
        }
        public IEnumerable<Product> GetByCategory(int cat)
        {
            return this.data.GetByCategory(cat);
        }
        public int Insert(Product product)
        {
            return this.data.Insert(product);
        }
        public int Update(Product product)
        {
            return this.data.Update(product);
        }
        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

        public IEnumerable<Product> SearchProduct(string searc)
        {
            return this.data.SearchProduct(searc);
        }
    }
}
