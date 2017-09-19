using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    class Product_DataAccess : iProduct_DataAccess
    {
        private DorDam_databaseContext context;

        public Product_DataAccess(DorDam_databaseContext context) 
        {
            this.context = context;
        }

        public IEnumerable<Product> GetAllValues()
        {
            return this.context.Products.ToList();
        }

        public Product Get(int id)
        {
            return this.context.Products.SingleOrDefault(x => x.Id == id);
        }

        public Product GetLastItem(int id)
        {
            
            return this.context.Products.Where(x => x.Category_ID == id).OrderByDescending(x => x.Id).Take(1).SingleOrDefault();
            
        }

        public IEnumerable<Product> GetByCategory(int cat)
        {
            return this.context.Products.Where(x => x.Category_ID == cat).OrderByDescending(x => x.Id);
        }

        public int Insert(Product product)
        {
            this.context.Products.Add(product);
            return this.context.SaveChanges();
        }

        public int Update(Product product)
        {
            Product pro = this.context.Products.SingleOrDefault(x => x.Id == product.Id);

            pro.Product_Price = product.Product_Price;
            pro.Product_Quantity = product.Product_Quantity;
            pro.Product_About = product.Product_About;

            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            Product pro = this.context.Products.SingleOrDefault(x => x.Id == id);
            this.context.Products.Remove(pro);

            return this.context.SaveChanges();
        }

        public IEnumerable<Product> SearchProduct(string searc)
        {
            return this.context.Products.Where(x => x.Product_Name.Contains(searc));
        }
    }
}
