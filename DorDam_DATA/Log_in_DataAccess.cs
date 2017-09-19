using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DorDam_DATA
{
    class Log_in_DataAccess : iLog_in_DataAccess
    {
        private DorDam_databaseContext context;

        public Log_in_DataAccess(DorDam_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Log_in> GetAllValues()
        {
            return this.context.Log_in.ToList();
        }

        public Log_in Get(string user_name, string pass)
        {
            return this.context.Log_in.SingleOrDefault(x => x.User_Name == user_name && x.Password == pass);
        }

        public int Insert(Log_in logIn)
        {
            this.context.Log_in.Add(logIn);
            return this.context.SaveChanges();
        }

        public int Update(Log_in logIn)
        {
            Log_in log = this.context.Log_in.SingleOrDefault(x => x.User_Name == logIn.User_Name);
            log.Password = logIn.Password;

            return this.context.SaveChanges();
        }

        public int Delete(string user_name)
        {
            Log_in log = this.context.Log_in.SingleOrDefault(x => x.User_Name == user_name);
            this.context.Log_in.Remove(log);

            return this.context.SaveChanges();
        }
    }
}
