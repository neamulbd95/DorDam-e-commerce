using DorDam_ENTITY;
using DorDam_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    class Buying_History_Service : iBuying_History_Service
    {
        private iBuying_History_DataAccess data;

        public Buying_History_Service(iBuying_History_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Buying_History> GetAllValues(string userName)
        {
            return this.data.GetAllValues(userName);
        }
        public Buying_History Get(int id)
        {
            return this.data.Get(id);
        }
        public int Insert(Buying_History Buying_History)
        {
            return this.data.Insert(Buying_History);
        }
        public int Update(Buying_History Buying_History)
        {
            return this.data.Update(Buying_History);
        }
        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
