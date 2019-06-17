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
            context.MapRoute(
                "AccesoAlumnosMaestro",
                "Api/AndroidMaestros/Alumnos/{code}/{GrupoID}",
                new { controller = "AndroidMaestros", action = "Alumnos", code = "", GrupoID = "" }
            );
            context.MapRoute(
                "AccesoSubirCalificacionMaestro",
                "Api/AndroidMaestros/SubirCalificacion/{AlumnoID}/{MateriaID}/{Unidad}/{Calificacion}",
                new { controller = "AndroidMaestros", action = "SubirCalificacion", AlumnoID = "", MateriaID = "", Unidad = "", Calificacion = "" }
            );
        }
    }
}