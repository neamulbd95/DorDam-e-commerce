using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    public interface iBuying_History_Service
    {
        IEnumerable<Buying_History> GetAllValues(string userName);
        Buying_History Get(int id);
        int Insert(Buying_History Buying_History);
        int Update(Buying_History Buying_History);
        int Delete(int id);
    }
}
