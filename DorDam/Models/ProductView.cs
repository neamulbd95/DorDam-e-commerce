using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DorDam.Models
{
    public class ProductView
    {
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductPicture { get; set; }
        public string ProductAbout { get; set; }
    }
}