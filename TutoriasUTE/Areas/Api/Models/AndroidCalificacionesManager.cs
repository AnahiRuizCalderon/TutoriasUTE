using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutoriasUTE.Models;

namespace TutoriasUTE.Areas.Api.Models
{
    public class AndroidCalificacionesManager
    {

        public static bool SubirCalificacion(AndroidCalificaciones calificacion)
        {
            TutoriasUTEDbContext dbCtx = new TutoriasUTEDbContext();

            //se crea el objeto para subir
            StudentCourseGrade newGrade = new StudentCourseGrade();

            //se le agregan los valores
            newGrade.StudentID = calificacion.AlumnoID;
            newGrade.CourseID = calificacion.MateriaID;
            newGrade.Unit = calificacion.Unidad;
            newGrade.Grade = calificacion.Calificacion;
            newGrade.Date = DateTime.Now;

            //se agrega a la base de datos
            dbCtx.StudentCourseGrades.Add(newGrade);
            dbCtx.SaveChanges();

            return true;
        }

    }
}