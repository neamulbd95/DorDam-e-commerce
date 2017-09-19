using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DorDam.Models
{
    public class ReportDetails
    {
        public string productName { get; set; }
        public string productPicture { get; set; }
        public string category { get; set; }
        public string subCategory { get; set; }
        public int productPrice { get; set; }
        public int totalSellingQuantity { get; set; }
    }
}