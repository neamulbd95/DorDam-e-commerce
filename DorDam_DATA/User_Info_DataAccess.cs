using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    class User_Info_DataAccess : iUser_Info_DataAccess
    {
        private DorDam_databaseContext context;

        public User_Info_DataAccess(DorDam_databaseContext context) 
        {
            this.context = context;
        }

        public IEnumerable<User_Info> GetAllValues()
        {
            return this.context.User_Info.ToList();
        }

        public User_Info Get(string user_name)
        {
            return this.context.User_Info.SingleOrDefault(x => x.User_name == user_name);
        }

         public User_Info GetUserName(int id)
        {
            return this.context.User_Info.SingleOrDefault(x=> x.Id == id);
        }

        public int Insert(User_Info User_Info)
        {
            this.context.User_Info.Add(User_Info);
            return this.context.SaveChanges();
        }
        public int Update(User_Info User_Info)
        {
            User_Info info = this.context.User_Info.SingleOrDefault(x => x.User_name == User_Info.User_name);

            info.User_Full_name = User_Info.User_Full_name;
            info.User_Mobile = User_Info.User_Mobile;

            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            User_Info info = this.context.User_Info.SingleOrDefault(x => x.Id == id);
            this.context.User_Info.Remove(info);

            return this.context.SaveChanges();
        }
    }
}
