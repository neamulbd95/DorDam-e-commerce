using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    public interface iCategory_Service
    {
        IEnumerable<Category> GetAllValues();
        Category Get(int id);
        int Insert(Category category);
        int Update(Category category);
        int Delete(int id);
    }
}
