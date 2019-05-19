using CommonCLI.Interface;
using Generics.Model;
using System;
using System.Collections.Generic;

namespace CommonCLI.DataStructure
{
	public class ProcessSort : IGenericProcess
	{
		public void Run()
		{
			RunDictionary();
			RunSortedDictionary();
		}

		private void RunDictionary()
		{
			Dictionary<string, List<Employee>> employeesByName = new Dictionary<string, List<Employee>>
			{
				{"Sales", new List<Employee> { new Employee(), new Employee(), new Employee() } },
				{"Engineering", new List<Employee> { new Employee(), new Employee() } }
			};
			IterateDictionary(employeesByName);
		}

		private void RunSortedDictionary()
		{
			SortedDictionary<string, List<Employee>> employeesByName = new SortedDictionary<string, List<Employee>>
			{
				{"Sales", new List<Employee> { new Employee(), new Employee(), new Employee() } },
				{"Engineering", new List<Employee> { new Employee(), new Employee() } }
			};
			IterateDictionary(employeesByName);
		}

		private void IterateDictionary(IReadOnlyDictionary<string, List<Employee>> employeesByName)
		{
			foreach (KeyValuePair<string, List<Employee>> employees in employeesByName)
			{
				Console.WriteLine($"The count of the employees for {employees.Key} is {employees.Value.Count}");
			}
		}
	}
}