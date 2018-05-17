using System.Web;
using System.Web.Mvc;

namespace DTcmsMVC_BTSTP_EF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
