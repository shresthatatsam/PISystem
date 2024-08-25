using Microsoft.EntityFrameworkCore;
using PISystem.Models;

namespace PISystem
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }



        public DbSet<UserInformationViewModel> UserInformations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserInformationViewModel>(x =>
                            {
                                x.ToTable("UserInformations");
                                x.HasKey(e => e.user_id);
                                x.Property(e => e.user_name).IsRequired();
                                x.Property(e => e.password).IsRequired();
                                x.Property(e => e.is_active).HasDefaultValue(true);

                            });



            base.OnModelCreating(modelBuilder);
        }

    }
}


