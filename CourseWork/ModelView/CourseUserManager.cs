using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
namespace CourseWork.Models
{
    public class CourseUserManager : UserManager<User>
    {
        public CourseUserManager(IUserStore<User> store)
        : base(store)
        {
        }
        public static CourseUserManager Create(IdentityFactoryOptions<CourseUserManager> options,
                                                IOwinContext context)
        {
            WaterMeterContext db = context.Get<WaterMeterContext>();
            CourseUserManager manager = new CourseUserManager(new UserStore<User>(db));
            return manager;
        }
    }
}