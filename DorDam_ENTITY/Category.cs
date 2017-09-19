using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_ENTITY
{
    public class Category
    {
        public int Id { get; set; }
        public string Category_Name  { get; set; }

        public IEnumerable<Sub_Category> Sub_Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
