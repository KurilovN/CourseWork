namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Trainings", "Coach_CoachId", "dbo.Coaches");
            RenameColumn(table: "dbo.Trainings", name: "Coach_CoachId", newName: "Coach_Id");
            RenameIndex(table: "dbo.Trainings", name: "IX_Coach_CoachId", newName: "IX_Coach_Id");
            DropPrimaryKey("dbo.Coaches");
            AddColumn("dbo.Coaches", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Coaches", "Id");
            AddForeignKey("dbo.Trainings", "Coach_Id", "dbo.Coaches", "Id");
            DropColumn("dbo.Coaches", "CoachId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coaches", "CoachId", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Trainings", "Coach_Id", "dbo.Coaches");
            DropPrimaryKey("dbo.Coaches");
            DropColumn("dbo.Coaches", "Id");
            AddPrimaryKey("dbo.Coaches", "CoachId");
            RenameIndex(table: "dbo.Trainings", name: "IX_Coach_Id", newName: "IX_Coach_CoachId");
            RenameColumn(table: "dbo.Trainings", name: "Coach_Id", newName: "Coach_CoachId");
            AddForeignKey("dbo.Trainings", "Coach_CoachId", "dbo.Coaches", "CoachId");
        }
    }
}
