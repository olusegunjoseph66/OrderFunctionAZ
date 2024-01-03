using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Function.Constant
{
    public static class ApiConstant
    {
        //public const string autorefreshplant = "https://dms-order-ms.azurewebsites.net/api/azurefunction/azure-refresh-plants";
        public const string autorefreshplant = "#[AppMicroservices:Order:BaseUrl]#/api/azurefunction/azure-refresh-plants";
        public const string autosubmitorders = "#[AppMicroservices:Order:BaseUrl]#/api/azurefunction/azure-submit-Orders";
        //public const string autoabandonshoppingcarts = "https://dms-order-ms.azurewebsites.net/azurefuction/abandonshoppingcartsfunction";
        //public const string autoabandonshoppingcarts = "https://dms-order-ms.azurewebsites.net/api/azurefunction/azure-abandon-carts";
        public const string autoabandonshoppingcarts = "#[AppMicroservices:Order:BaseUrl]#/api/azurefunction/azure-abandon-carts";
        //public const string autosubmitorders = "https://localhost:44325/azurefuction/azure-submit-Orders";
        //public const string autorefreshorders = "https://dms-order-ms.azurewebsites.net/azurefuction/refreshordersfunction";
        public const string autorefreshorders = "#[AppMicroservices:Order:BaseUrl]#/api/azurefunction/azure-refresh-Orders";

    }
}
