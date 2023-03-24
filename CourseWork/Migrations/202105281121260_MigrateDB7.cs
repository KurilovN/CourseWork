namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB7 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.GymFeedbacks", new[] { "User_Id" });
            DropColumn("dbo.GymFeedbacks", "UserId");
            RenameColumn(table: "dbo.GymFeedbacks", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.GymFeedbacks", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.GymFeedbacks", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.GymFeedbacks", new[] { "UserId" });
            AlterColumn("dbo.GymFeedbacks", "UserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.GymFeedbacks", name: "UserId", newName: "User_Id");
            AddColumn("dbo.GymFeedbacks", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.GymFeedbacks", "User_Id");
        }
    }
}
