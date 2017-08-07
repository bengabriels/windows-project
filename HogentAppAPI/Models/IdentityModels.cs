using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;
using HogentAppAPI.Models;

namespace HogentAppApi.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // some custom setup code added by yourself – this bit could be anything
            //modelBuilder.Entity<Student>().HasMany<Education>(s => s.VoorkeursOpleidingen);



            // the all important base class call! Add this line to make your problems go away.
            base.OnModelCreating(modelBuilder);
            /*var config = modelBuilder.Entity<Student>();
            config.ToTable("Students");*/
        }

        public System.Data.Entity.DbSet<HogentAppAPI.Models.Education> Educations { get; set; }

        public System.Data.Entity.DbSet<HogentAppAPI.Models.Campus> Campus { get; set; }

        public System.Data.Entity.DbSet<HogentAppAPI.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<HogentAppAPI.Models.Gebeurtenis> Gebeurtenis { get; set; }

        public System.Data.Entity.DbSet<HogentAppAPI.Models.Article> Articles { get; set; }
    }
}