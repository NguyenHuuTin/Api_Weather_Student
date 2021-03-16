using System.Web;
using System.Web.Mvc;

namespace NguyenHuuTin_5951071106
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
