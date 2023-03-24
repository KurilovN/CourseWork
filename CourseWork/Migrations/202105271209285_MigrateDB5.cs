namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.GymSchedules", new[] { "TrainGymID" });
            CreateIndex("dbo.GymSchedules", "TrainGymId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.GymSchedules", new[] { "TrainGymId" });
            CreateIndex("dbo.GymSchedules", "TrainGymID");
        }
    }
}
