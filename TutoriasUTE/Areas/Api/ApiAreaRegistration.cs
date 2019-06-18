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

            //LOGIN
            context.MapRoute(
                "AccesoLogin",
                "Api/AndroidLogin/Login/{us}/{pass}/{role}",
                new { controller = "AndroidLogin", action = "Login", us = "", pass = "", role = "" }
            );

            //MAESTRO
            context.MapRoute(
                "AccesoMateriasMaestro",
                "Api/AndroidMaestros/Materias/{code}/{MaestroID}",
                new { controller = "AndroidMaestros", action = "Materias", code = "", MaestroID = "" }
            );

            //TUTOR
            context.MapRoute(
                "AccesoMateriasTutor",
                "Api/AndroidTutores/Materias/{code}/{MaestroID}",
                new { controller = "AndroidTutores", action = "Materias", code = "", MaestroID = "" }
            );
        }
    }
}