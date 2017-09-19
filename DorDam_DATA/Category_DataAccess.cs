using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    class Category_DataAccess : iCategory_DataAccess
    {
        private DorDam_databaseContext context;

        public Category_DataAccess(DorDam_databaseContext context) 
        {
            this.context = context;
        }

        public IEnumerable<Category> GetAllValues()
        {
            return this.context.Categories.ToList();
        }

        public Category Get(int id)
        {
            return this.context.Categories.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Category category)
        {
            this.context.Categories.Add(category);
            return this.context.SaveChanges();
        }
        public int Update(Category category) 
        {
            Category cat = this.context.Categories.SingleOrDefault(x => x.Id == category.Id);
            cat.Category_Name = category.Category_Name;

            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            Category cat = this.context.Categories.SingleOrDefault(x => x.Id == id);
            this.context.Categories.Remove(cat);

            return this.context.SaveChanges();
        }
    }
}
