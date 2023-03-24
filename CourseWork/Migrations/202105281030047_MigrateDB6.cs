namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GymFeedbacks", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.GymFeedbacks", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.GymFeedbacks", "User_Id");
            AddForeignKey("dbo.GymFeedbacks", "User_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.GymFeedbacks", "ClientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GymFeedbacks", "ClientId", c => c.Int(nullable: false));
            DropForeignKey("dbo.GymFeedbacks", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.GymFeedbacks", new[] { "User_Id" });
            DropColumn("dbo.GymFeedbacks", "User_Id");
            DropColumn("dbo.GymFeedbacks", "UserId");
        }
    }
}
