namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GymFeedbacks", "TrainGym_TrainGymId", "dbo.TrainGyms");
            DropForeignKey("dbo.GymSchedules", "TrainGym_TrainGymId", "dbo.TrainGyms");
            DropForeignKey("dbo.GymSeasonTickets", "TrainGym_TrainGymId", "dbo.TrainGyms");
            DropIndex("dbo.GymSeasonTickets", new[] { "TrainGym_TrainGymId" });
            DropIndex("dbo.GymFeedbacks", new[] { "TrainGym_TrainGymId" });
            DropIndex("dbo.GymSchedules", new[] { "TrainGym_TrainGymId" });
            RenameColumn(table: "dbo.Coaches", name: "TrainGym_TrainGymId", newName: "TrainGymId");
            RenameColumn(table: "dbo.GymFeedbacks", name: "TrainGym_TrainGymId", newName: "TrainGymId");
            RenameColumn(table: "dbo.GymSchedules", name: "TrainGym_TrainGymId", newName: "TrainGymID");
            RenameColumn(table: "dbo.GymSeasonTickets", name: "TrainGym_TrainGymId", newName: "TrainGymId");
            RenameIndex(table: "dbo.Coaches", name: "IX_TrainGym_TrainGymId", newName: "IX_TrainGymId");
            AlterColumn("dbo.GymSeasonTickets", "TrainGymId", c => c.Int(nullable: false));
            AlterColumn("dbo.GymFeedbacks", "TrainGymId", c => c.Int(nullable: false));
            AlterColumn("dbo.GymSchedules", "TrainGymID", c => c.Int(nullable: false));
            CreateIndex("dbo.GymSeasonTickets", "TrainGymId");
            CreateIndex("dbo.GymFeedbacks", "TrainGymId");
            CreateIndex("dbo.GymSchedules", "TrainGymID");
            AddForeignKey("dbo.GymFeedbacks", "TrainGymId", "dbo.TrainGyms", "TrainGymId", cascadeDelete: true);
            AddForeignKey("dbo.GymSchedules", "TrainGymID", "dbo.TrainGyms", "TrainGymId", cascadeDelete: true);
            AddForeignKey("dbo.GymSeasonTickets", "TrainGymId", "dbo.TrainGyms", "TrainGymId", cascadeDelete: true);
            DropColumn("dbo.Coaches", "GymId");
            DropColumn("dbo.GymSeasonTickets", "GymId");
            DropColumn("dbo.GymFeedbacks", "GymId");
            DropColumn("dbo.GymSchedules", "GymID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GymSchedules", "GymID", c => c.Int(nullable: false));
            AddColumn("dbo.GymFeedbacks", "GymId", c => c.Int(nullable: false));
            AddColumn("dbo.GymSeasonTickets", "GymId", c => c.Int(nullable: false));
            AddColumn("dbo.Coaches", "GymId", c => c.Int(nullable: false));
            DropForeignKey("dbo.GymSeasonTickets", "TrainGymId", "dbo.TrainGyms");
            DropForeignKey("dbo.GymSchedules", "TrainGymID", "dbo.TrainGyms");
            DropForeignKey("dbo.GymFeedbacks", "TrainGymId", "dbo.TrainGyms");
            DropIndex("dbo.GymSchedules", new[] { "TrainGymID" });
            DropIndex("dbo.GymFeedbacks", new[] { "TrainGymId" });
            DropIndex("dbo.GymSeasonTickets", new[] { "TrainGymId" });
            AlterColumn("dbo.GymSchedules", "TrainGymID", c => c.Int());
            AlterColumn("dbo.GymFeedbacks", "TrainGymId", c => c.Int());
            AlterColumn("dbo.GymSeasonTickets", "TrainGymId", c => c.Int());
            RenameIndex(table: "dbo.Coaches", name: "IX_TrainGymId", newName: "IX_TrainGym_TrainGymId");
            RenameColumn(table: "dbo.GymSeasonTickets", name: "TrainGymId", newName: "TrainGym_TrainGymId");
            RenameColumn(table: "dbo.GymSchedules", name: "TrainGymID", newName: "TrainGym_TrainGymId");
            RenameColumn(table: "dbo.GymFeedbacks", name: "TrainGymId", newName: "TrainGym_TrainGymId");
            RenameColumn(table: "dbo.Coaches", name: "TrainGymId", newName: "TrainGym_TrainGymId");
            CreateIndex("dbo.GymSchedules", "TrainGym_TrainGymId");
            CreateIndex("dbo.GymFeedbacks", "TrainGym_TrainGymId");
            CreateIndex("dbo.GymSeasonTickets", "TrainGym_TrainGymId");
            AddForeignKey("dbo.GymSeasonTickets", "TrainGym_TrainGymId", "dbo.TrainGyms", "TrainGymId");
            AddForeignKey("dbo.GymSchedules", "TrainGym_TrainGymId", "dbo.TrainGyms", "TrainGymId");
            AddForeignKey("dbo.GymFeedbacks", "TrainGym_TrainGymId", "dbo.TrainGyms", "TrainGymId");
        }
    }
}
