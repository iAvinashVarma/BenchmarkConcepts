using Generics.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Generics.DataAccess
{
	public class EmployeeDb : DbContext
	{
		public DbSet<Employee> Employees { get; set; }
	}
}
