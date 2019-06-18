using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutoriasUTE.Areas.Api.Models;

namespace TutoriasUTE.Areas.Api.Controllers
{
    public class AndroidTutoresController : Controller
    {
        public JsonResult Materias(string code, int MaestroID)
        {
            return Json(AndroidMateriasManager.MateriasTutor(MaestroID), JsonRequestBehavior.AllowGet);
        }
    }
}
