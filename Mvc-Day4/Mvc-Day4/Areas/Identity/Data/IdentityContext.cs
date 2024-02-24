using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mvc_Day4.Areas.Identity.Data;
using Mvc_Day4.Models;

namespace Mvc_Day4.Areas.Identity.Data;

public class IdentityContext : IdentityDbContext<User>
{
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    {
    }

     public DbSet<Movie> Movies { get; set; }
     public DbSet<MovieType> MovieTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Movie>().HasData(new Movie[]
        {
            new Movie() {Id=1, Name="Se7en",PublishDate=1998,MovieStar="Brad Bit",Category="Greater than 15",MovieLength=2.15f,Rate=8.5f,MovieTypeId=1 },
            new Movie() {Id=2, Name="ShutterIsland", PublishDate=2010,MovieStar="Leonardo DeCabrio",Category="Greater than 16",MovieLength=2.30f,Rate=8f,MovieTypeId=2 },
            new Movie() {Id=3, Name="MissionImpossible", PublishDate=2012,MovieStar="Tom Cruise",Category="Public",MovieLength=2f,Rate=8f,MovieTypeId=4 },
            new Movie() {Id=4, Name="Interstellar", PublishDate=2014,MovieStar="Mathio Makonhy",Category="Public",MovieLength=3f,Rate=9f,MovieTypeId=3 }
        }
            );

        builder.Entity<MovieType>().HasData(new MovieType[]
        {
            new MovieType(){Id=1, Name="Suspense"},
            new MovieType(){Id=2, Name="Dramatic" } ,
            new MovieType(){Id=3, Name="Sciense Fiction"}   ,
            new MovieType(){Id=4, Name="Action"}
        }

            );
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new UserEntityConfiguration());
        builder.ApplyConfiguration(new RoleEntityConfiguration());
        builder.Seed();

    }
}

public class UserEntityConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u=>u.FirstName).HasMaxLength(15);
        builder.Property(u => u.LastName).HasMaxLength(15);
        builder.Property(u => u.Age);

    }
}

public class RoleEntityConfiguration : IEntityTypeConfiguration<AppIdentityRole>
{
    public void Configure(EntityTypeBuilder<AppIdentityRole> builder)
    {
       

    }
}
