using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_ENTITY
{
    public class Buying_History
    {
        public int Id { get; set; }
        public int Product_ID { get; set; }
        public string User_Name { get; set; }
        public int Buying_Quantity { get; set; }
        public DateTime Buying_Date { get; set; }
    }
}
