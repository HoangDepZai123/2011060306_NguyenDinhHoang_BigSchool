using System.Web;
using System.Web.Mvc;

namespace _2011060306_NguyenDinhHoang_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
