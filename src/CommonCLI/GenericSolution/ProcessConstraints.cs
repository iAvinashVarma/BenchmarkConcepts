using CommonCLI.Interface;
using Generics.DataAccess;
using Generics.DataAccess.Interface;
using Generics.Model;
using System;
using System.Data.Entity;

namespace CommonCLI.GenericSolution
{
	public class ProcessConstraints : IGenericProcess
	{
		public void Run()
		{
			Database.SetInitializer(new DropCreateDatabaseAlways<EmployeeDb>());
			using (IRepository<Employee> employeeRepository = new SqlRepository<Employee>(new EmployeeDb()))
			{
				AddEmployees(employeeRepository);
				AddManagers(employeeRepository);
				CountEmployees(employeeRepository);
				QueryEmployees(employeeRepository);
				DumpPeople(employeeRepository);
			}
		}

		private void AddManagers(IWriteOnlyRepository<Manager> employeeRepository)
		{
			employeeRepository.Add(new Manager { Name = "Bill" });
			employeeRepository.Commit();
		}

		private void DumpPeople(IReadOnlyRepository<Person> employeeRepository)
		{
			var employees = employeeRepository.FindAll();
			foreach (var employee in employees)
			{
				Console.WriteLine(employee.Name);
			}
		}

		private void QueryEmployees(IRepository<Employee> employeeRepository)
		{
			var employee = employeeRepository.FindById(1);
			Console.WriteLine(employee.Name);
		}

		private void CountEmployees(IRepository<Employee> employeeRepository)
		{
			Console.WriteLine(employeeRepository.FindAll().CountAsync().GetAwaiter().GetResult());
		}

		private void AddEmployees(IRepository<Employee> employeeRepository)
		{
			employeeRepository.Add(new Employee { Name = "Steve" });
			employeeRepository.Add(new Employee { Name = "Charles" });
			employeeRepository.Commit();
		}
	}
}