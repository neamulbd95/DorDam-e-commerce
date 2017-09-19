using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DorDam.Models
{
    public class ProductCategory
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productCategoryName { get; set; }
        public string productSubCategoryName { get; set; }
        public int productPrice { get; set; }
        public int productQuantity { get; set; }
        public string productPicture { get; set; }
        public string productAbout { get; set; }
                        
    }
}