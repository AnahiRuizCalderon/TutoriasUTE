using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutoriasUTE.Areas.Api.Models;

namespace TutoriasUTE.Areas.Api.Controllers
{
    public class AndroidRecordatoriosController : Controller
    {

        public JsonResult Recordatorios(string code, int role)
        {
            return Json(AndroidRecordatoriosManager.Recordatorios(role), JsonRequestBehavior.AllowGet);
        }
    }
}
