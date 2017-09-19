using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_ENTITY
{
    public class Sub_Category
    {
        public int Id { get; set; }
        public string Sub_Category_Name { get; set; }
        public int Category_ID { get; set; }

        public Category Category { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
