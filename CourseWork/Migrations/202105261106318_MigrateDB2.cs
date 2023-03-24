namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GymEquipments", "EquipmentId", c => c.Int(nullable: false));
            DropColumn("dbo.GymEquipments", "Equipment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GymEquipments", "Equipment", c => c.Int(nullable: false));
            DropColumn("dbo.GymEquipments", "EquipmentId");
        }
    }
}
