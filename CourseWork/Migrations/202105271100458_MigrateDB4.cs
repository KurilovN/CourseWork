namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Coaches", "TrainGymId", "dbo.TrainGyms");
            DropIndex("dbo.Coaches", new[] { "TrainGymId" });
            AlterColumn("dbo.Coaches", "TrainGymId", c => c.Int(nullable: false));
            CreateIndex("dbo.Coaches", "TrainGymId");
            AddForeignKey("dbo.Coaches", "TrainGymId", "dbo.TrainGyms", "TrainGymId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coaches", "TrainGymId", "dbo.TrainGyms");
            DropIndex("dbo.Coaches", new[] { "TrainGymId" });
            AlterColumn("dbo.Coaches", "TrainGymId", c => c.Int());
            CreateIndex("dbo.Coaches", "TrainGymId");
            AddForeignKey("dbo.Coaches", "TrainGymId", "dbo.TrainGyms", "TrainGymId");
        }
    }
}
