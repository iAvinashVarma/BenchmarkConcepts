using CommonCLI.Interface;
using Generics.Model;
using System;
using System.Collections.Generic;

namespace CommonCLI.DataStructure
{
	public class ProcessDictionary : IGenericProcess
	{
		public void Run()
		{
			Dictionary<string, Employee> employeesByName = new Dictionary<string, Employee>()
			{
				{ "Steve", new Employee { Name = "Steve" } },
				{ "Charles", new Employee { Name = "Charles" } },
				{ "Bill", new Employee { Name = "Bill" } }
			};
			FindNameByIndex(employeesByName);
			IterateDictionary(employeesByName);
		}

		private void IterateDictionary(Dictionary<string, Employee> employeesByName)
		{
			foreach (var employeeKeyValue in employeesByName)
			{
				Console.WriteLine($"{employeeKeyValue.Key}:{employeeKeyValue.Value.Name}");
			}
		}

		private void FindNameByIndex(Dictionary<string, Employee> employeesByName)
		{
			var steve = employeesByName["Steve"];
			Console.WriteLine(steve.Name);
		}
	}
}