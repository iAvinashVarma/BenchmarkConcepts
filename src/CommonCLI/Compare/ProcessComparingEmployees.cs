using CommonCLI.Interface;
using Generics.Model;
using System;
using System.Collections.Generic;

namespace CommonCLI.Compare
{
	public class ProcessComparingEmployees : IGenericProcess
	{
		private const string Divider = "**********";

		public void Run()
		{
			Console.WriteLine($"{Divider} Dictionary - List {Divider}");
			ProcessDictionaryList();
			Console.WriteLine($"{Divider} SortedDictionary - HashSet {Divider}");
			ProcessSortedDictionaryHashSet();
			Console.WriteLine($"{Divider} SortedDictionary - SortedSet {Divider}");
			ProcessSortedDictionarySortedSet();
		}

		private void ProcessDictionaryList()
		{
			DepartmentList departments = new DepartmentList();
			AddEmployeeData(departments);
			IterateDictionary(departments);
		}

		private void ProcessSortedDictionaryHashSet()
		{
			DepartmentHashSet departments = new DepartmentHashSet();
			AddEmployeeData(departments);
			IterateDictionary(departments);
		}

		private void ProcessSortedDictionarySortedSet()
		{
			var departments = new DepartmentSortedSet();
			AddEmployeeData(departments);
			IterateDictionary(departments);
		}

		private void AddEmployeeData(IDepartmentCollection<Employee> departments)
		{
			string engineering = "Engineering";
			string sales = "Sales";

			departments.Add(engineering, new Employee { Name = "Charles Babbage" });
			departments.Add(engineering, new Employee { Name = "Steve Jobs" });
			departments.Add(engineering, new Employee { Name = "Bill Gates" });
			departments.Add(engineering, new Employee { Name = "Bill Gates" });


			departments.Add(sales, new Employee { Name = "Elon Musk" });
			departments.Add(sales, new Employee { Name = "Mark Shuttleworth" });
			departments.Add(sales, new Employee { Name = "Elon Musk" });
		}

		private void IterateDictionary(IDepartmentEnumerable<string, Employee> departments)
		{
			foreach (var department in departments)
			{
				Console.WriteLine($"{department.Key}");
				foreach (var employee in department.Value)
				{
					Console.WriteLine($"\t{employee.Name}");
				}
			}
		}
	}
}