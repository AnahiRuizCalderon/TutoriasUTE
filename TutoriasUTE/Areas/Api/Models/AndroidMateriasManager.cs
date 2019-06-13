using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutoriasUTE.Models;

namespace TutoriasUTE.Areas.Api.Models
{
    public class AndroidMateriasManager
    {
        public static List<AndroidMateria> Materias(int MaestroID)
        {
            TutoriasUTEDbContext dbCtx = new TutoriasUTEDbContext();

            List<AndroidMateria> materias = new List<AndroidMateria>();

            //obtener todas las materias que imparte el maestro
            var queryMaterias = (from c in dbCtx.Courses
                                 where c.TeacherID == MaestroID
                                 select new
                                 {
                                     MateriaID = c.ID,
                                     MateriaDesc = c.Description
                                 }).ToList();

            //seleccionar las materias que estan en uso
            foreach (var materia in queryMaterias)
            {
                var queryMateriaInGroup = (from cgc in dbCtx.ClassGroupCourses
                                           join cg in dbCtx.ClassGroups on cgc.ClassGroupID equals cg.ID
                                           join t in dbCtx.Teachers on cg.TeacherID equals t.ID
                                           where cgc.CourseID == materia.MateriaID
                                           select new
                                           {
                                               GroupID = cg.ID,
                                               GroupLongID = cg.GroupID,
                                               GroupTutor = t.LastNameP + " " + t.LastNameM + " " + t.FirstMidName
                                           }).ToList();

                //se crean los objetos Android materia
                foreach(var materiaInGroup in queryMateriaInGroup)
                {
                    AndroidMateria objMateria = new AndroidMateria();

                    //se asignan los valores
                    objMateria.MateriaID = materia.MateriaID;
                    objMateria.MateriaDesc = materia.MateriaDesc;
                    objMateria.GrupoID = materiaInGroup.GroupID;
                    objMateria.GrupoLongID = materiaInGroup.GroupLongID;
                    objMateria.GrupoTutor = materiaInGroup.GroupTutor;

                    //se agrega a la lista
                    materias.Add(objMateria);
                }
            }

            return materias;
        }
    }
}