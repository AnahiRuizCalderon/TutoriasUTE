using System.Web.Mvc;

namespace TutoriasUTE.Areas.Api
{
    public class ApiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Api";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Api_default",
                "Api/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "AccesoLogin",
                "Api/AndroidLogin/Login/{us}/{pass}/{role}",
                new { controller = "AndroidLogin", action = "Login", us = "", pass = "", role = "" }
            );
        }
    }
}