namespace TutoriasUTE.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TutoriasUTE.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TutoriasUTE.Models.TutoriasUTEDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TutoriasUTE.Models.TutoriasUTEDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //INSERT CAREERS
            var carrers = new List<Career>
            {
                new Career { Description = "Tecnologías de la Información y de la Comunicación Área Sistemas Informáticos", Abbreviation = "TICSI"},
                new Career { Description = "Tecnologías de la Información y de la Comunicación Área Desarrollo de Software Multiplataforma", Abbreviation = "TIDSM"},
                new Career { Description = "Nanotecnología Área Materiales", Abbreviation = "NAN-MAT"},
                new Career { Description = "Químicas Área Tecnología Ambiental", Abbreviation = "QTA"},
                new Career { Description = "Lengua Inglesa", Abbreviation = "LI"},
                new Career { Description = "Mantenimiento Área Industrial", Abbreviation = "MAI"},
                new Career { Description = "Mecatrónica Área Automatización", Abbreviation = "MEC-AUT"},
                new Career { Description = "Desarrollo de Negocios Área Mercadotecnia", Abbreviation = "DNMER"},
                new Career { Description = "Desarrollo de Negocios Área Logística y Transporte", Abbreviation = "DNLT"},
                new Career { Description = "Logística Área Cadena de Suministros", Abbreviation = "LCS"}
            };
            carrers.ForEach(c => context.Careers.AddOrUpdate(a => a.Abbreviation, c));
            context.SaveChanges();

            //INSERT TURNS
            var turns = new List<Turn>
            {
                new Turn { Description = "Matutino"},
                new Turn { Description = "Nocturno"}
            };
            turns.ForEach(t => context.Turns.AddOrUpdate(d => d.Description, t));
            context.SaveChanges();

            //INSERT MODALITIES
            var modalities = new List<Modality>
            {
                new Modality { Description = "BIS"},
                new Modality { Description = "TRAD"}
            };
            modalities.ForEach(m => context.Modalities.AddOrUpdate(d => d.Description, m));
            context.SaveChanges();

            //INSERT ROLES
            var roles = new List<Role>
            {
                new Role { Description = "Docente"},
                new Role { Description = "Tutor"}
            };
            roles.ForEach(r => context.Roles.AddOrUpdate(d => d.Description, r));
            context.SaveChanges();

            //INSERT SITUATIONS
            var situations = new List<Situation>
            {
                new Situation { Description = "Regular"},
                new Situation { Description = "Irregular"}
            };
            situations.ForEach(s => context.Situations.AddOrUpdate(d => d.Description, s));
            context.SaveChanges();

            //INSERT ADMINISTRATOR
            var administrators = new List<Administrator>
            {
                new Administrator { UserName = "admin", UserPassword = "uteadmin"}
            };
            administrators.ForEach(a => context.Administrators.AddOrUpdate(un => un.UserName, a));
            context.SaveChanges();

            //INSERT DATABASE CREATION INTO LOG
            var logs = new List<Log>
            {
                new Log { Date = DateTime.Now, Description = "Se creó la base de datos"}
            };
            logs.ForEach(l => context.Logs.AddOrUpdate(d => d.Description, l));
            context.SaveChanges();
        }
    }
}
