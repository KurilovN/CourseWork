using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CourseWork.Models
{
    public class WaterMeterContext : IdentityDbContext<User>
    {
        public WaterMeterContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static WaterMeterContext Create()
        {
            return new WaterMeterContext();
        }
        public DbSet<MarkWaterMeter> MarkWaterMeters { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<TypesWaterMeters> TypesWaterMeters { get; set; }
        public DbSet<WaterMeter> WaterMeters { get; set; }
        public DbSet<Client> Clients { get; set; }
        public class AdminDbInitializer : DropCreateDatabaseAlways<WaterMeterContext>
        {
            protected override void Seed(WaterMeterContext db)
            {
                CreateUsers(db);
                base.Seed(db);
            }
            public void CreateUsers(WaterMeterContext db)
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
           
        }
    }
}