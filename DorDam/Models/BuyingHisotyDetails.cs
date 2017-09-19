using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DorDam.Models
{
    public class BuyingHisotyDetails
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }
        public string prductPicture { get; set; }
        public int buyingQuantity { get; set; }        
        public DateTime buyingDate { get; set; }
        public string userName { get; set; }
    }
}