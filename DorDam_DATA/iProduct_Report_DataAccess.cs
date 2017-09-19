using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    public interface iProduct_Report_DataAccess
    {
        IEnumerable<Product_Report> GetAllValues();
        Product_Report Get(int id);
        int Insert(Product_Report Product_Report);
        int Update(Product_Report Product_Report);
        int Delete(int id);

        Product_Report report();
    }
}
