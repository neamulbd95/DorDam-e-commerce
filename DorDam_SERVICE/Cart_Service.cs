using DorDam_ENTITY;
using DorDam_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    class Cart_Service : iCart_Service
    {
        private iCart_DataAccess data;

        public Cart_Service(iCart_DataAccess data) 
        {
            this.data = data;
        }

        public IEnumerable<Cart> GetAllValues()
        {
            return this.data.GetAllValues();
        }

        public Cart GetbyID(int i)
        {
            return this.data.GetbyID(i);
        }

        public IEnumerable<Cart> Get(string user)
        {
            return this.data.Get(user);
        }
        public int Insert(Cart carts)
        {
            return this.data.Insert(carts);
        }
        public int Update(Cart carts)
        {
            return this.data.Update(carts);
        }
        public int DeleteItem(int id)
        {
            return this.data.DeleteItem(id);
        }
        public int DeleteUserCart(string username)
        {
            return this.data.DeleteUserCart(username);
        }

        public int countRows(string username)
        {
            return this.data.countRows(username);
        }
    }
}
