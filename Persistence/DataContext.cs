using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence
{
	public class DataContext : DbContext
	{
		public DataContext() 
		{
			this.ChangeTracker.LazyLoadingEnabled = false;
		}
		public DataContext(DbContextOptions options) : base(options) 
		{ 
			this.ChangeTracker.LazyLoadingEnabled = false;
		}

		public virtual DbSet<Country> Countries { get; set; }

		public virtual DbSet<LineOfBusiness> LineOfBusinesses { get; set; }

		public virtual DbSet<CountryLineOfBusiness> CountryLineOfBusinesses { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				IConfigurationRoot configuration = new ConfigurationBuilder()
					.SetBasePath(Directory.GetCurrentDirectory())
					.AddJsonFile("appsettings.json")
					.Build();
				var connectionString = configuration.GetConnectionString("DefaultConnection");
				optionsBuilder.UseSqlite(connectionString);
			}
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<CountryLineOfBusiness>(x => x.HasKey(cl => new { cl.CountryId, cl.LineOfBusinessId }));

			builder.Entity<CountryLineOfBusiness>()
			    .HasOne(x => x.Country)
			    .WithMany(c => c.CountryLineOfBusinesses)
			    .HasForeignKey(x => x.CountryId);

			builder.Entity<CountryLineOfBusiness>()
				  .HasOne(x => x.LineOfBusiness)
				  .WithMany(l => l.CountryLineOfBusinesses)
				  .HasForeignKey(x => x.LineOfBusinessId);
		}
	}
}