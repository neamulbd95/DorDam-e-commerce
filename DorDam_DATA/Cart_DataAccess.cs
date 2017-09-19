using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    class Cart_DataAccess : iCart_DataAccess
    {
        private DorDam_databaseContext context;

        public Cart_DataAccess(DorDam_databaseContext context) 
        {
            this.context = context;
        }

        public IEnumerable<Cart> GetAllValues()
        {
            return this.context.Carts.ToList();
        }

        public Cart GetbyID(int i) 
        {
            return this.context.Carts.SingleOrDefault(x => x.Id == i);
        }

        public IEnumerable<Cart> Get(string user)
        {
            return this.context.Carts.Where(x => x.Username == user).ToList();
        }

        public int Insert(Cart carts) 
        {
            this.context.Carts.Add(carts);
            return this.context.SaveChanges();
        }

        public int Update(Cart carts)
        {
            Cart car = this.context.Carts.SingleOrDefault(x => x.Id == carts.Id);
            car.BuyingQuantity = carts.BuyingQuantity;

            return this.context.SaveChanges();
        }

        public int DeleteItem(int id)
        {
            Cart car = this.context.Carts.SingleOrDefault(x => x.Id == id);
            this.context.Carts.Remove(car);

            return this.context.SaveChanges();
        }

        public int DeleteUserCart(string username)
        {
            IEnumerable<Cart> car = this.context.Carts.Where(x => x.Username == username);
            this.context.Carts.RemoveRange(car);

            return this.context.SaveChanges();
        }

        public int countRows(string username)
        {
            return this.context.Carts.Where(x => x.Username == username).Count();
        }
    }
}
