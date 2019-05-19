using CommonCLI.Interface;
using Generics.Model;
using System;

namespace CommonCLI.Collections
{
	public class ProcessArray : IGenericProcess
	{
		public void Run()
		{
			Employee[] employees = GetEmployees();

			ProcessForEach(employees);

			ProcessFor(employees);

			employees = Resize(employees);
		}

		private static Employee[] Resize(Employee[] employees)
		{
			Array.Resize(ref employees, 10);
			return employees;
		}

		private static void ProcessFor(Employee[] employees)
		{
			for (int i = 0; i < employees.Length; i++)
			{
				Console.WriteLine(employees[i].Name);
			}
		}

		private static void ProcessForEach(Employee[] employees)
		{
			foreach (var employee in employees)
			{
				Console.WriteLine(employee.Name);
			}
		}

		private Employee[] GetEmployees()
		{
			return new Employee[]
			{
				new Employee { Name = "Bill Gates" },
				new Employee { Name = "Steve Jobs" }
			};
		}
	}
}
