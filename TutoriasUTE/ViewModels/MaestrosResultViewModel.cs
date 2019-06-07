using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TutoriasUTE.ViewModels
{
    public class MaestrosResultViewModel
    {
        [Display(Name = "Maestros")]
        public List<MaestrosViewModel> Maestros { get; set; }
    }
}