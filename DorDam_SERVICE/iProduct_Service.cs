using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    public interface iProduct_Service
    {
        IEnumerable<Product> GetAllValues();
        Product Get(int id);
        Product GetLastItem(int id);
        IEnumerable<Product> GetByCategory(int cat);
        int Insert(Product product);
        int Update(Product product);
        int Delete(int id);
        IEnumerable<Product> SearchProduct(string searc);
    }
}
