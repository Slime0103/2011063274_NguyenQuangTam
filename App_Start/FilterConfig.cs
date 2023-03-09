using System.Web;
using System.Web.Mvc;

namespace _2011063274_NguyenQuangTam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
