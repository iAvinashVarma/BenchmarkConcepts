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

		private void ProcessSortedDictionarySortedSet()
		{
			SortedDictionary<string, SortedSet<Employee>> departments = new SortedDictionary<string, SortedSet<Employee>>
			{
				{ "Engineering", new SortedSet<Employee>(new EmployeeComparer()) },
				{ "Sales", new SortedSet<Employee>(new EmployeeComparer()) }
			};
			AddEmployeeData(departments);
			IterateDictionary(departments);
		}

		private void IterateDictionary(SortedDictionary<string, SortedSet<Employee>> departments)
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

		private void AddEmployeeData(SortedDictionary<string, SortedSet<Employee>> departments)
		{
			departments["Engineering"].Add(new Employee { Name = "Charles Babbage" });
			departments["Engineering"].Add(new Employee { Name = "Steve Jobs" });
			departments["Engineering"].Add(new Employee { Name = "Bill Gates" });
			departments["Engineering"].Add(new Employee { Name = "Bill Gates" });

			departments["Sales"].Add(new Employee { Name = "Mark Shuttleworth" });
			departments["Sales"].Add(new Employee { Name = "Elon Musk" });
			departments["Sales"].Add(new Employee { Name = "Elon Musk" });
		}

		private void ProcessSortedDictionaryHashSet()
		{
			SortedDictionary<string, HashSet<Employee>> departments = new SortedDictionary<string, HashSet<Employee>>
			{
				{ "Engineering", new HashSet<Employee>(new EmployeeComparer()) },
				{ "Sales", new HashSet<Employee>(new EmployeeComparer()) }
			};
			AddEmployeeData(departments);
			IterateDictionary(departments);
		}

		private void IterateDictionary(SortedDictionary<string, HashSet<Employee>> departments)
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

		private void AddEmployeeData(SortedDictionary<string, HashSet<Employee>> departments)
		{
			departments["Engineering"].Add(new Employee { Name = "Charles Babbage" });
			departments["Engineering"].Add(new Employee { Name = "Steve Jobs" });
			departments["Engineering"].Add(new Employee { Name = "Bill Gates" });
			departments["Engineering"].Add(new Employee { Name = "Bill Gates" });

			departments["Sales"].Add(new Employee { Name = "Mark Shuttleworth" });
			departments["Sales"].Add(new Employee { Name = "Elon Musk" });
			departments["Sales"].Add(new Employee { Name = "Elon Musk" });
		}

		private void ProcessDictionaryList()
		{
			Dictionary<string, List<Employee>> departments = new Dictionary<string, List<Employee>>
			{
				{ "Engineering", new List<Employee>() },
				{ "Sales", new List<Employee>() }
			};
			AddEmployeeData(departments);
			IterateDictionary(departments);
		}

		private void AddEmployeeData(Dictionary<string, List<Employee>> departments)
		{
			departments["Engineering"].Add(new Employee { Name = "Charles Babbage" });
			departments["Engineering"].Add(new Employee { Name = "Steve Jobs" });
			departments["Engineering"].Add(new Employee { Name = "Bill Gates" });
			departments["Engineering"].Add(new Employee { Name = "Bill Gates" });

			departments["Sales"].Add(new Employee { Name = "Mark Shuttleworth" });
			departments["Sales"].Add(new Employee { Name = "Elon Musk" });
			departments["Sales"].Add(new Employee { Name = "Elon Musk" });
		}

		private static void IterateDictionary(Dictionary<string, List<Employee>> departments)
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