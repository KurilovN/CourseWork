namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Trainings", "Coach_CoachId", "dbo.Coaches");
            DropIndex("dbo.Trainings", new[] { "Coach_CoachId" });
            CreateIndex("dbo.GymTrainings", "CoachId");
            AddForeignKey("dbo.GymTrainings", "CoachId", "dbo.Coaches", "CoachId", cascadeDelete: true);
            DropColumn("dbo.Trainings", "Coach_CoachId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trainings", "Coach_CoachId", c => c.Int());
            DropForeignKey("dbo.GymTrainings", "CoachId", "dbo.Coaches");
            DropIndex("dbo.GymTrainings", new[] { "CoachId" });
            CreateIndex("dbo.Trainings", "Coach_CoachId");
            AddForeignKey("dbo.Trainings", "Coach_CoachId", "dbo.Coaches", "CoachId");
        }
    }
}
