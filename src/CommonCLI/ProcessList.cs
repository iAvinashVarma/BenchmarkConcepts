using Generics.Model;
using System;
using System.Collections.Generic;

namespace CommonCLI
{
	public class ProcessList : SingletonBase<ProcessList>
	{
		public void Run()
		{
			List<Employee> employees = GetEmployees();
			AddEmployees(employees);
			ProcessForEach(employees);
			ProcessFor(employees);
		}

		private void AddEmployees(List<Employee> employees)
		{
			employees.Add(new Employee { Name = "Elon Musk" });
		}

		private List<Employee> GetEmployees()
		{
			return new List<Employee>
			{
				new Employee { Name = "Bill Gates" },
				new Employee { Name = "Steve Jobs" }
			};
		}

		private void ProcessForEach(List<Employee> employees)
		{
			foreach (var employee in employees)
			{
				Console.WriteLine(employee.Name);
			}
		}

		private void ProcessFor(List<Employee> employees)
		{
			for (int i = 0; i < employees.Count; i++)
			{
				Console.WriteLine(employees[i].Name);
			}
		}
	}
}
