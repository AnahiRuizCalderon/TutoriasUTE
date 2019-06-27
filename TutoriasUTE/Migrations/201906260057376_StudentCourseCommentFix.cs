namespace TutoriasUTE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentCourseCommentFix : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.StudentCourseComment");
            AddPrimaryKey("dbo.StudentCourseComment", new[] { "StudentID", "CourseID", "Date" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.StudentCourseComment");
            AddPrimaryKey("dbo.StudentCourseComment", new[] { "StudentID", "CourseID" });
        }
    }
}
