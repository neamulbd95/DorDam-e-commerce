using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    public interface iCart_DataAccess
    {
        IEnumerable<Cart> GetAllValues();
        Cart GetbyID(int i);
        IEnumerable<Cart> Get(string user);
        int Insert(Cart carts);
        int Update(Cart carts);
        int DeleteItem(int id);
        int DeleteUserCart(string username);
        int countRows(string username);
    }
}
