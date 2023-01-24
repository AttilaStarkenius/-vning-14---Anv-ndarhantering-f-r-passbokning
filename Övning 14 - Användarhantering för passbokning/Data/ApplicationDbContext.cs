using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Övning_14___Användarhantering_för_passbokning.Models;
using System.Reflection.Emit;

namespace Övning_14___Användarhantering_för_passbokning.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<GymClass> GymClasses { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationUserGymClass> ApplicationUserGymClasses { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<ApplicationUser>(entity =>
            {
                // Primary key
                //entity.HasKey(u => u.Id);

                entity.HasMany(b => b.ApplicationUserGymClasses);

                //entity.Property(e => e.Name);
                ////.IsRequired()
                ////.HasMaxLength(50);
                //entity.Property(e => e.StartTime);
                ////entity.Property(e => e.Duration);
                //builder.Entity<GymClass>() // Why this? EndPoints is a getter only property
                //.Ignore(gymClass => gymClass.Duration);
                //entity.Property(e => e.EndTime);
                //entity.Property(e => e.Description);

            });

            builder.Entity<GymClass>(entity =>
            {
                // Primary key
                entity.HasKey(u => u.Id);

                entity.HasMany(b => b.ApplicationUserGymClasses);

                entity.Property(e => e.Name);
                //.IsRequired()
                //.HasMaxLength(50);
                entity.Property(e => e.StartTime);
                entity.Property(e => e.Duration);
                builder.Entity<GymClass>()
                .Ignore(gymClass => gymClass.EndTime);
                //entity.Property(e => e.EndTime);
                entity.Property(e => e.Description);

            });


            //builder.Entity<ApplicationUserGymClass>()
        //.HasKey(bc => new { bc.ApplicationUserID, bc.GymClassID });
            builder.Entity<ApplicationUserGymClass>()
                .HasOne(bc => bc.applicationUser);
            //.WithMany(b => b.ApplicationUserGymClasses)
            //.HasForeignKey(bc => bc.Id);
            builder.Entity<ApplicationUserGymClass>()
                .HasOne(bc => bc.gymClass);
            //.WithMany(c => c.ApplicationUserGymClasses)
            //.HasForeignKey(bc => bc.Id);



            base.OnModelCreating(builder);

        }
    }

}
