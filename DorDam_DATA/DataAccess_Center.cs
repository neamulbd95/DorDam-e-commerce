using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_DATA
{
    public abstract class DataAccess_Center
    {
        public static iCategory_DataAccess GetCategory_DataAccess() 
        {
            return new Category_DataAccess(new DorDam_databaseContext());
        }

        public static iSub_Category_DataAccess GetSub_Category_DataAccess()
        {
            return new Sub_Category_DataAccess(new DorDam_databaseContext());
        }

        public static iProduct_DataAccess GetProduct_DataAccess()
        {
            return new Product_DataAccess(new DorDam_databaseContext());
        }

        public static iProduct_Report_DataAccess GetProduct_Report_DataAccess()
        {
            return new Product_Report_DataAccess(new DorDam_databaseContext());
        }

        public static iBuying_History_DataAccess GetBuying_History_DataAccess()
        {
            return new Buying_History_DataAccess(new DorDam_databaseContext());
        }

        public static iUser_Info_DataAccess GetUser_Info_DataAccess()
        {
            return new User_Info_DataAccess(new DorDam_databaseContext());
        }

        public static iLog_in_DataAccess GetLog_in_DataAccess()
        {
            return new Log_in_DataAccess(new DorDam_databaseContext());
        }

        public static iCart_DataAccess GetCart_DataAccess()
        {
            return new Cart_DataAccess(new DorDam_databaseContext());
        }
    }
}
