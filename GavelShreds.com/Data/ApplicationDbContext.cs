using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GavelShreds.com.Models;
using GavelShreds.com.Models.Band;

namespace GavelShreds.com.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<BandMember> BandMembers { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Merchandise> Merchandise { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
