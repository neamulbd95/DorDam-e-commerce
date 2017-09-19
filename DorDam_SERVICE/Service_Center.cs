using DorDam_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorDam_SERVICE
{
    public abstract class Service_Center
    {
        public static iCategory_Service GetCategory_Service()
        {
            return new Category_Service(DataAccess_Center.GetCategory_DataAccess());
        }

        public static iSub_Category_Service GetSub_Category_Service()
        {
            return new Sub_Category_Service(DataAccess_Center.GetSub_Category_DataAccess());
        }

        public static iProduct_Service GetProduct_Service()
        {
            return new Product_Service(DataAccess_Center.GetProduct_DataAccess());
        }

        public static iBuying_History_Service GetBuying_History_Service()
        {
            return new Buying_History_Service(DataAccess_Center.GetBuying_History_DataAccess());
        }

        public static iProduct_Report_Service GetProduct_Report_Service()
        {
            return new Product_Report_Service(DataAccess_Center.GetProduct_Report_DataAccess());
        }

        public static iUser_Info_Service GetUser_Info_Service()
        {
            return new User_Info_Service(DataAccess_Center.GetUser_Info_DataAccess());
        }

        public static iLog_in_Service GetLog_in_Service()
        {
            return new Log_in_Service(DataAccess_Center.GetLog_in_DataAccess());
        }

        public static iCart_Service GetCart_Service()
        {
            return new Cart_Service(DataAccess_Center.GetCart_DataAccess());
        }
    }
}
