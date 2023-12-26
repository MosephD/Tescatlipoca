using Microsoft.EntityFrameworkCore;
using Tescatlipoca.Data.Models;

namespace Tescatlipoca.Data
{
    public class MainDbContext : DbContext
    {

        public MainDbContext(DbContextOptions<MainDbContext> options)
         : base(options)
        {

        }
        public DbSet<User> Users => Set<User>();

        public DbSet<UserCredentials> User_Credentials => Set<UserCredentials>();

        public DbSet<UserEmails> Emails => Set<UserEmails>();

        public DbSet<UserPC> PC => Set<UserPC>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(a => a.ID_USER);

            modelBuilder.Entity<UserCredentials>()
                .HasKey(b => b.ID_CREDENTIALS);


            modelBuilder.Entity<UserEmails>()
               .HasKey(c => c.USER_EMAILS_ID);


            modelBuilder.Entity<UserPC>()
                .HasKey(d => d.ID_PC);

        }

    }
}
