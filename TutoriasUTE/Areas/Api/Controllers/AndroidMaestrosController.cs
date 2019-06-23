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
            return Json(AndroidMateriasManager.MateriasMaestro(MaestroID), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Alumnos(string code, int GrupoID)
        {
            return Json(AndroidAlumnosManager.Alumnos(GrupoID), JsonRequestBehavior.AllowGet);
        }
    }
}
