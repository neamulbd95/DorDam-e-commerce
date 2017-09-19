using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DorDam_ENTITY
{
    public class Product
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public int Category_ID { get; set; }
        public int Sub_Category_ID { get; set; }
        public int Product_Price { get; set; }
        public int Product_Quantity { get; set; }
        public string Product_Picture { get; set; }
        public string Product_About { get; set; }

        

    }
}
