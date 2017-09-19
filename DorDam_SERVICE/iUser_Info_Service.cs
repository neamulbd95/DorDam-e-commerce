using DorDam_ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    public interface iUser_Info_Service
    {
        IEnumerable<User_Info> GetAllValues();
        User_Info Get(string user_name);
        User_Info GetUserName(int id);
        int Insert(User_Info User_Info);
        int Update(User_Info User_Info);
        int Delete(int id);
    }
}
