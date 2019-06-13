using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutoriasUTE.Models;

namespace TutoriasUTE.Areas.Api.Models
{
    public class AndroidLoginManager
    {

        public static int isLoged(AndroidLogin login) {


            TutoriasUTEDbContext dbCtx = new TutoriasUTEDbContext();

            //se busca si existe
            var queryLogin = (from t in dbCtx.Teachers
                              join tr in dbCtx.TeacherRoles on t.ID equals tr.TeacherID
                              where tr.RoleID == login.role
                              where t.UserName == login.user && t.UserPassword == login.pass
                              select new
                              {
                                  ID = t.ID
                              }).SingleOrDefault();

            if (queryLogin != null)
            {
                return queryLogin.ID;
            }
            else
            {
                return 0;
            }

        }
    }
}