using CommonCLI.Interface;
using Generics.Model;
using System;
using System.Collections.Generic;

namespace CommonCLI.DataStructure
{
	public class ProcessList : IGenericProcess
	{
		public void Run()
		{
			List<Employee> employees = GetEmployees();
			AddEmployees(employees);
			ProcessForEach(employees);
			ProcessFor(employees);
			// ProcessCapacity();
		}

		private void ProcessCapacity()
		{
			var numbers = new List<int>(capacity: 10);
			var capacity = -1;
			while (true)
			{
				if (numbers.Capacity != capacity)
				{
					capacity = numbers.Capacity;
					Console.WriteLine(capacity);
				}
				numbers.Add(1);
			}
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
