using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    public interface iSub_Category_DataAccess
    {
        IEnumerable<Sub_Category> GetAllValues();
        IEnumerable<Sub_Category> GetList(int id);
        Sub_Category Get(int id);
        int Insert(Sub_Category sub_Category);
        int Update(Sub_Category sub_Category);
        int Delete(int id);
    }
}
