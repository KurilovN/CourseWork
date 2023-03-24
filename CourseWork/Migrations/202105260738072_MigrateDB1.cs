namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Trainings", "Coach_Id", "dbo.Coaches");
            DropIndex("dbo.Trainings", new[] { "Coach_Id" });
            RenameColumn(table: "dbo.Trainings", name: "Coach_Id", newName: "Coach_CoachId");
            DropPrimaryKey("dbo.Coaches");
            AddColumn("dbo.Coaches", "CoachId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Trainings", "Coach_CoachId", c => c.Int());
            AddPrimaryKey("dbo.Coaches", "CoachId");
            CreateIndex("dbo.Trainings", "Coach_CoachId");
            AddForeignKey("dbo.Trainings", "Coach_CoachId", "dbo.Coaches", "CoachId");
            DropColumn("dbo.Coaches", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coaches", "Id", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Trainings", "Coach_CoachId", "dbo.Coaches");
            DropIndex("dbo.Trainings", new[] { "Coach_CoachId" });
            DropPrimaryKey("dbo.Coaches");
            AlterColumn("dbo.Trainings", "Coach_CoachId", c => c.String(maxLength: 128));
            DropColumn("dbo.Coaches", "CoachId");
            AddPrimaryKey("dbo.Coaches", "Id");
            RenameColumn(table: "dbo.Trainings", name: "Coach_CoachId", newName: "Coach_Id");
            CreateIndex("dbo.Trainings", "Coach_Id");
            AddForeignKey("dbo.Trainings", "Coach_Id", "dbo.Coaches", "Id");
        }
    }
}
