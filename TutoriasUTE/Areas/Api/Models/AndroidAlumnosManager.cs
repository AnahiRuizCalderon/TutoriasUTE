using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutoriasUTE.Models;

namespace TutoriasUTE.Areas.Api.Models
{
    public class AndroidAlumnosManager
    {
        public static List<AndroidAlumnos> Alumnos(int GrupoID)
        {
            TutoriasUTEDbContext dbCtx = new TutoriasUTEDbContext();

            List<AndroidAlumnos> alumnos = new List<AndroidAlumnos>();

            //se buscan los alumnos pertenecientes al grupo
            var queryAlumnos = (from cgs in dbCtx.ClassGroupStudents
                                join s in dbCtx.Students on cgs.StudentID equals s.ID
                                where cgs.ClassGroupID == GrupoID
                                orderby s.LastNameP ascending
                                select new
                                {
                                    StudentID = s.ID,
                                    Matricula = s.Registration,
                                    Nombre = s.LastNameP + " " + s.LastNameM + " " + s.FirstMidName
                                }).ToList();

            //por cada uno se agrega un elemento
            foreach(var alumno in queryAlumnos)
            {
                //se crea el objeto 
                AndroidAlumnos objAlumno = new AndroidAlumnos();

                //se agregan los valores
                objAlumno.AlumnoID = alumno.StudentID;
                objAlumno.Matricula = alumno.Matricula;
                objAlumno.Nombre = alumno.Nombre;

                //se agrega a la lista
                alumnos.Add(objAlumno);
            }

            return alumnos;

        }
    }
}