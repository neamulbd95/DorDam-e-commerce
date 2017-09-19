using DorDam_ENTITY;
using DorDam_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    class Log_in_Service : iLog_in_Service
    {
        private iLog_in_DataAccess data;

        public Log_in_Service(iLog_in_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Log_in> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public Log_in Get(string user_name, string pass)
        {
            return this.data.Get(user_name, pass);
        }
        public int Insert(Log_in Log_in)
        {
            return this.data.Insert(Log_in);
        }
        public int Update(Log_in Log_in)
        {
            return this.data.Update(Log_in);
        }
        public int Delete(string user_name)
        {
            return this.data.Delete(user_name);
        }
    }
}
