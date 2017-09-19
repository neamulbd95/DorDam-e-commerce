using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    class Sub_Category_DataAccess : iSub_Category_DataAccess
    {
        private DorDam_databaseContext context;

        public Sub_Category_DataAccess(DorDam_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Sub_Category> GetAllValues()
        {
            return this.context.Sub_Category.ToList();
        }

        public IEnumerable<Sub_Category> GetList(int id)
        {
            return this.context.Sub_Category.Where(x => x.Category_ID == id).ToList();
        }

        public Sub_Category Get(int id)
        {
            return this.context.Sub_Category.SingleOrDefault(x=>x.Id == id);
        }

        public int Insert(Sub_Category sub_category)
        {
            this.context.Sub_Category.Add(sub_category);
            return this.context.SaveChanges();
        }
        public int Update(Sub_Category sub_category)
        {
            Sub_Category cat = this.context.Sub_Category.SingleOrDefault(x => x.Id == sub_category.Id);
            cat.Sub_Category_Name = sub_category.Sub_Category_Name;

            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            Sub_Category suBcat = this.context.Sub_Category.SingleOrDefault(x => x.Id == id);
            this.context.Sub_Category.Remove(suBcat);

            return this.context.SaveChanges();
        }
    }
}
