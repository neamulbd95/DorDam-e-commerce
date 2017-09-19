using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    class Buying_History_DataAccess : iBuying_History_DataAccess
    {
        private DorDam_databaseContext context;

        public Buying_History_DataAccess(DorDam_databaseContext context)
        {
            this.context = context;
        }
        public IEnumerable<Buying_History> GetAllValues(string userName)
        {
            return this.context.Buying_History.Where(x => x.User_Name == userName).ToList();
        }

        public Buying_History Get(int id)
        {
            return this.context.Buying_History.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Buying_History buying_history)
        {
            this.context.Buying_History.Add(buying_history);
            return this.context.SaveChanges();
        }

        public int Update(Buying_History buying_history)
        {
            Buying_History buying = this.context.Buying_History.SingleOrDefault(x => x.Id == buying_history.Id);
            buying.Id = buying_history.Id;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Buying_History buying = this.context.Buying_History.SingleOrDefault(x => x.Id == id);
            this.context.Buying_History.Remove(buying);

            return this.context.SaveChanges();
        }

    }
}
