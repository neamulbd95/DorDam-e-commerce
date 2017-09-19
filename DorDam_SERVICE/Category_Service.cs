using DorDam_ENTITY;
using DorDam_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    class Category_Service : iCategory_Service
    {
        private iCategory_DataAccess data;

        public Category_Service(iCategory_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Category> GetAllValues()
        {
            return this.data.GetAllValues();
        }

        public Category Get(int id)
        {
            return this.data.Get(id);
        }
        public int Insert(Category category)
        {
            return this.data.Insert(category);
        }
        public int Update(Category category)
        {
            return this.data.Update(category);
        }
        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
