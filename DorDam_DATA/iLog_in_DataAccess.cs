using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    public interface iLog_in_DataAccess
    {
        IEnumerable<Log_in> GetAllValues();
        Log_in Get(string user_name, string pass);
        int Insert(Log_in Log_in);
        int Update(Log_in Log_in);
        int Delete(string user_name);
    }
}
