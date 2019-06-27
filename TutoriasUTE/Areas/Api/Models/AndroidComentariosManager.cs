using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutoriasUTE.Models;

namespace TutoriasUTE.Areas.Api.Models
{
    public class AndroidComentariosManager
    {
        public static List<AndroidComentariosReturn> SubirComentario(AndroidComentarios comentario)
        {
            TutoriasUTEDbContext dbCtx = new TutoriasUTEDbContext();

            List<AndroidComentariosReturn> commentRet = new List<AndroidComentariosReturn>();

            //se crea el objeto para subir
            StudentCourseComment newComment = new StudentCourseComment();

            //se le agregan los valores
            newComment.StudentID = comentario.AlumnoID;
            newComment.CourseID = comentario.MateriaID;
            newComment.Description = comentario.Comentario;
            newComment.Date = DateTime.Now;

            //se agrega a la base de datos
            dbCtx.StudentCourseComments.Add(newComment);
            dbCtx.SaveChanges();

            //se regresa el objeto
            AndroidComentariosReturn objCommentRet = new AndroidComentariosReturn();
            objCommentRet.Status = true;

            commentRet.Add(objCommentRet);

            return commentRet;
        }

        public static List<AndroidComentariosAlumno> ComentariosAlumno(int AlumnoID, int MateriaID)
        {
            TutoriasUTEDbContext dbCtx = new TutoriasUTEDbContext();

            List<AndroidComentariosAlumno> comentariosRet = new List<AndroidComentariosAlumno>();

            var query = (from scc in dbCtx.StudentCourseComments
                         where scc.CourseID == MateriaID
                         where scc.StudentID == AlumnoID
                         select new
                         {
                             Comment = scc.Description
                         }).ToList();

            foreach (var comment in query)
            {
                AndroidComentariosAlumno comentario = new AndroidComentariosAlumno();
                comentario.Comentario = comment.Comment;

                comentariosRet.Add(comentario);
            }

            return comentariosRet;
        }
    }
}