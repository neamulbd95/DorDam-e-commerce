using DorDam_ENTITY;
using DorDam_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    class User_Info_Service : iUser_Info_Service
    {
        private iUser_Info_DataAccess data;

        public User_Info_Service(iUser_Info_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<User_Info> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public User_Info Get(string user_name)
        {
            return this.data.Get(user_name);
        }
        public User_Info GetUserName(int id)
        {
            return this.data.GetUserName(id);
        }
        public int Insert(User_Info User_Info)
        {
            return this.data.Insert(User_Info);
        }
        public int Update(User_Info User_Info)
        {
            return this.data.Update(User_Info);
        }
        public int Delete(int id)
        {
            return this.data.Delete(id);
        }

    }
}
