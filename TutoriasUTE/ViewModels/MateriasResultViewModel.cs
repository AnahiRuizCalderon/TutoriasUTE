using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TutoriasUTE.ViewModels
{
    public class MateriasResultViewModel
    {
        [Display(Name = "Materias")]
        public List<MateriasViewModel> Materias { get; set; }
    }
}