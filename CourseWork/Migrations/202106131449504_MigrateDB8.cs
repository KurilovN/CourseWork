namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB8 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.GymTrainings", "TrainingId");
            AddForeignKey("dbo.GymTrainings", "TrainingId", "dbo.Trainings", "TrainingId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GymTrainings", "TrainingId", "dbo.Trainings");
            DropIndex("dbo.GymTrainings", new[] { "TrainingId" });
        }
    }
}
