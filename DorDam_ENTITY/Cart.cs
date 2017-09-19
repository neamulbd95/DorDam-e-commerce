using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_ENTITY
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ProductSubCategory { get; set; }
        public string ProductPicture { get; set; }
        public int ProductPrice { get; set; }
        public int BuyingQuantity { get; set; }
        public string Username { get; set; }

    }
}
