using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutoriasUTE.Areas.Api.Models;

namespace TutoriasUTE.Areas.Api.Controllers
{
    public class AndroidMaestrosController : Controller
    {
        public JsonResult Materias(string code, int MaestroID)
        {
            return Json(AndroidMateriasManager.Materias(MaestroID), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Alumnos(string code, int GrupoID)
        {
            return Json(AndroidAlumnosManager.Alumnos(GrupoID), JsonRequestBehavior.AllowGet);
        }

        public JsonResult SubirCalificacion(int AlumnoID, int MateriaID, int Unidad, string Calificacion)
        {
            //se crea el objeto
            AndroidCalificaciones calificacion = new AndroidCalificaciones();
            calificacion.AlumnoID = AlumnoID;
            calificacion.MateriaID = MateriaID;
            calificacion.Unidad = Unidad;
            calificacion.Calificacion = Calificacion;

            return Json(AndroidCalificacionesManager.SubirCalificacion(calificacion), JsonRequestBehavior.AllowGet);
        }
    }
}
