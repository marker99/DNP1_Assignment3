using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Persistence
{
	public class AdultDBContext : DbContext
	{
		public DbSet<Adult> Adults { get; set; }
		public DbSet<Job> Jobs { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//name of the database
			optionsBuilder.UseSqlite(@"Data Source = Adults.db");
		}
	}
}