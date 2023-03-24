using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CourseWork.Models
{
    public class GymContext: IdentityDbContext<User>
    {
        public GymContext()
     : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static GymContext Create()
        {
            return new GymContext();
        }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentFunction> EquipmentFunctions { get; set; }
        public DbSet<GymEquipment> GymEquipments { get; set; }
        public DbSet<GymFeedback> GymFeedbacks { get; set; }
        public DbSet<GymSchedule> GymSchedules { get; set; }
        public DbSet<GymSeasonTicket> GymSeasonTickets { get; set; }
        public DbSet<GymTraining> GymTrainings { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<SeasonTicket> SeasonTickets { get; set; }
        public DbSet<TrainGym> TrainGyms { get; set; }
        public DbSet<Training> Trainings { get; set; }
    }
    public class AdminDbInitializer : DropCreateDatabaseAlways<GymContext>
    {
        protected override void Seed(GymContext db)
        {
            CreateUsers(db);
            base.Seed(db);
        }
        public void CreateUsers(GymContext db)
        {
            var userManager = new CourseUserManager(new UserStore<User>(db));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            // создаем две роли
            var role1 = new IdentityRole { Name = "admin" };
            var role2 = new IdentityRole { Name = "user" };

            // добавляем роли в бд
            roleManager.Create(role1);
            roleManager.Create(role2);

            // создаем админа
            var admin = new User { Email = "admin1", UserName = "admin1" };
            string passwordAdmin = "admin1";
            var result = userManager.Create(admin, passwordAdmin);

            // если создание админа прошло успешно
            if (result.Succeeded)
            {
                // добавляем для админа роль
                userManager.AddToRole(admin.Id, role1.Name);
            }

            // создаем пользователя
            var user = new User { Email = "user1", UserName = "user1" };
            string passwordUser = "user11";
            result = userManager.Create(user, passwordUser);

            // если создание пользователя прошло успешно
            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(user.Id, role2.Name);
            }
        }
        public void CreateTrainGyms()
        {

        }
        public void CreateEquipmentFuncions()
        {

        }
    }
}