using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TutoriasUTE.ViewModels
{
    public class GruposCrearAlumnosResultViewModel
    {
        [Display(Name = "Alumnos")]
        public List<GruposCrearAlumnosViewModel> Alumnos { get; set; }
    }
}