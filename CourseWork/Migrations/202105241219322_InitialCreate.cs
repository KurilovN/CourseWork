namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        CoachId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Gender = c.String(),
                        Experience = c.Int(nullable: false),
                        Education = c.String(),
                        QualificationId = c.Int(nullable: false),
                        GymId = c.Int(nullable: false),
                        TrainGym_TrainGymId = c.Int(),
                    })
                .PrimaryKey(t => t.CoachId)
                .ForeignKey("dbo.Qualifications", t => t.QualificationId, cascadeDelete: true)
                .ForeignKey("dbo.TrainGyms", t => t.TrainGym_TrainGymId)
                .Index(t => t.QualificationId)
                .Index(t => t.TrainGym_TrainGymId);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        TrainingId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Coach_CoachId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TrainingId)
                .ForeignKey("dbo.Coaches", t => t.Coach_CoachId)
                .Index(t => t.Coach_CoachId);
            
            CreateTable(
                "dbo.GymSeasonTickets",
                c => new
                    {
                        GymSeasonTicketId = c.Int(nullable: false, identity: true),
                        SeasonTicketId = c.Int(nullable: false),
                        GymId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Begin = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Training_TrainingId = c.Int(),
                        TrainGym_TrainGymId = c.Int(),
                    })
                .PrimaryKey(t => t.GymSeasonTicketId)
                .ForeignKey("dbo.Trainings", t => t.Training_TrainingId)
                .ForeignKey("dbo.SeasonTickets", t => t.SeasonTicketId, cascadeDelete: true)
                .ForeignKey("dbo.TrainGyms", t => t.TrainGym_TrainGymId)
                .Index(t => t.SeasonTicketId)
                .Index(t => t.Training_TrainingId)
                .Index(t => t.TrainGym_TrainGymId);
            
            CreateTable(
                "dbo.EquipmentFunctions",
                c => new
                    {
                        EquipmentFunctionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.EquipmentFunctionId);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        EquipmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EquipmentFunctionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EquipmentId)
                .ForeignKey("dbo.EquipmentFunctions", t => t.EquipmentFunctionId, cascadeDelete: true)
                .Index(t => t.EquipmentFunctionId);
            
            CreateTable(
                "dbo.GymEquipments",
                c => new
                    {
                        GymEquipmentId = c.Int(nullable: false, identity: true),
                        TrainGymId = c.Int(nullable: false),
                        Equipment = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GymEquipmentId)
                .ForeignKey("dbo.TrainGyms", t => t.TrainGymId, cascadeDelete: true)
                .Index(t => t.TrainGymId);
            
            CreateTable(
                "dbo.GymFeedbacks",
                c => new
                    {
                        GymFeedbackId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        GymId = c.Int(nullable: false),
                        GymAssessment = c.Int(nullable: false),
                        Comment = c.String(),
                        TrainGym_TrainGymId = c.Int(),
                    })
                .PrimaryKey(t => t.GymFeedbackId)
                .ForeignKey("dbo.TrainGyms", t => t.TrainGym_TrainGymId)
                .Index(t => t.TrainGym_TrainGymId);
            
            CreateTable(
                "dbo.GymSchedules",
                c => new
                    {
                        GymScheduleId = c.Int(nullable: false, identity: true),
                        GymID = c.Int(nullable: false),
                        Weekday = c.String(),
                        Begin = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        TrainGym_TrainGymId = c.Int(),
                    })
                .PrimaryKey(t => t.GymScheduleId)
                .ForeignKey("dbo.TrainGyms", t => t.TrainGym_TrainGymId)
                .Index(t => t.TrainGym_TrainGymId);
            
            CreateTable(
                "dbo.GymTrainings",
                c => new
                    {
                        GymTrainingId = c.Int(nullable: false, identity: true),
                        CoachId = c.Int(nullable: false),
                        TrainingId = c.Int(nullable: false),
                        Weekday = c.String(),
                        Begin = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        TrainGym_TrainGymId = c.Int(),
                    })
                .PrimaryKey(t => t.GymTrainingId)
                .ForeignKey("dbo.TrainGyms", t => t.TrainGym_TrainGymId)
                .Index(t => t.TrainGym_TrainGymId);
            
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        QualificationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.QualificationId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.SeasonTickets",
                c => new
                    {
                        SeasonTicketId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DurationInCU = c.Int(nullable: false),
                        TypeCU = c.String(),
                    })
                .PrimaryKey(t => t.SeasonTicketId);
            
            CreateTable(
                "dbo.TrainGyms",
                c => new
                    {
                        TrainGymId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        City = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.TrainGymId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.GymTrainings", "TrainGym_TrainGymId", "dbo.TrainGyms");
            DropForeignKey("dbo.GymSeasonTickets", "TrainGym_TrainGymId", "dbo.TrainGyms");
            DropForeignKey("dbo.GymSchedules", "TrainGym_TrainGymId", "dbo.TrainGyms");
            DropForeignKey("dbo.GymFeedbacks", "TrainGym_TrainGymId", "dbo.TrainGyms");
            DropForeignKey("dbo.GymEquipments", "TrainGymId", "dbo.TrainGyms");
            DropForeignKey("dbo.Coaches", "TrainGym_TrainGymId", "dbo.TrainGyms");
            DropForeignKey("dbo.GymSeasonTickets", "SeasonTicketId", "dbo.SeasonTickets");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Coaches", "QualificationId", "dbo.Qualifications");
            DropForeignKey("dbo.Equipments", "EquipmentFunctionId", "dbo.EquipmentFunctions");
            DropForeignKey("dbo.Trainings", "Coach_CoachId", "dbo.Coaches");
            DropForeignKey("dbo.GymSeasonTickets", "Training_TrainingId", "dbo.Trainings");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.GymTrainings", new[] { "TrainGym_TrainGymId" });
            DropIndex("dbo.GymSchedules", new[] { "TrainGym_TrainGymId" });
            DropIndex("dbo.GymFeedbacks", new[] { "TrainGym_TrainGymId" });
            DropIndex("dbo.GymEquipments", new[] { "TrainGymId" });
            DropIndex("dbo.Equipments", new[] { "EquipmentFunctionId" });
            DropIndex("dbo.GymSeasonTickets", new[] { "TrainGym_TrainGymId" });
            DropIndex("dbo.GymSeasonTickets", new[] { "Training_TrainingId" });
            DropIndex("dbo.GymSeasonTickets", new[] { "SeasonTicketId" });
            DropIndex("dbo.Trainings", new[] { "Coach_CoachId" });
            DropIndex("dbo.Coaches", new[] { "TrainGym_TrainGymId" });
            DropIndex("dbo.Coaches", new[] { "QualificationId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.TrainGyms");
            DropTable("dbo.SeasonTickets");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Qualifications");
            DropTable("dbo.GymTrainings");
            DropTable("dbo.GymSchedules");
            DropTable("dbo.GymFeedbacks");
            DropTable("dbo.GymEquipments");
            DropTable("dbo.Equipments");
            DropTable("dbo.EquipmentFunctions");
            DropTable("dbo.GymSeasonTickets");
            DropTable("dbo.Trainings");
            DropTable("dbo.Coaches");
        }
    }
}
