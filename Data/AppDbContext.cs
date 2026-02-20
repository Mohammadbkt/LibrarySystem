using library_system.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace library_system.Data
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);


            // Now configure your entities
            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            builder.Entity<User>().ToTable("User");
            builder.Entity<IdentityRole<int>>().ToTable("Role");
            builder.Entity<IdentityUserRole<int>>().ToTable("UserRole");
            builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaim");
            builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogin");
            builder.Entity<IdentityUserToken<int>>().ToTable("UserToken");
            builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaim");


            List<IdentityRole<int>> roles = new List<IdentityRole<int>>
            {
                
                new IdentityRole<int>
                {
                    Id = 1,
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = "UserConcurrencyStamp456"
                },
                new IdentityRole<int>
                {
                    Id = 2,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "AdminConcurrencyStamp456"
                },
            };
            builder.Entity<IdentityRole<int>>().HasData(roles);

            
        }
    }
}