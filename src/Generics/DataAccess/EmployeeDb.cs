using Generics.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Generics.DataAccess
{
	public class EmployeeDb : DbContext
	{
		public DbSet<Employee> Employees { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(GetConnectionString());
		}

		private string GetConnectionString()
		{
			var builder = new ConfigurationBuilder()
							.SetBasePath(Directory.GetCurrentDirectory())
							.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

			IConfigurationRoot configuration = builder.Build();

			return configuration.GetConnectionString("DefaultConnection");
		}
	}
}
