using DorDam_ENTITY;
using DorDam_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    class Sub_Category_Service : iSub_Category_Service
    {
        private iSub_Category_DataAccess data;

        public Sub_Category_Service(iSub_Category_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Sub_Category> GetAllValues()
        {
            return this.data.GetAllValues();
        }

        public IEnumerable<Sub_Category> GetList(int id)
        {
            return this.data.GetList(id);
        }

        public Sub_Category Get(int id)
        {
            return this.data.Get(id);
        }

        public int Insert(Sub_Category sub_Category)
        {
            return this.data.Insert(sub_Category);
        }

        public int Update(Sub_Category sub_Category)
        {
            return this.data.Update(sub_Category);
        }

        public int Delete(int id) 
        {
            return this.data.Delete(id);
        }
    }
}
