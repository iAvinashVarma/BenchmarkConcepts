using CommonCLI.Interface;
using Generics.Model;
using System;
using System.Collections.Generic;

namespace CommonCLI.Collections
{
	public class ProcessHashSet : IGenericProcess
	{
		public void Run()
		{
			HashSetInt();
			HashSetEmployee();
		}

		private void HashSetEmployee()
		{
			HashSet<Employee> hashset = new HashSet<Employee>();
			hashset.Add(new Employee { Name = "Steve" });
			hashset.Add(new Employee { Name = "Steve" });
			var employeeName = new Employee { Name = "Zuckerberg" };
			hashset.Add(employeeName);
			hashset.Add(employeeName);
			foreach (Employee item in hashset)
			{
				Console.WriteLine($"{item.Name} - {item.GetHashCode()}");
			}
		}

		private void HashSetInt()
		{
			HashSet<int> hashset = new HashSet<int>
			{
				1,
				2,
				2,
				1
			};

			foreach (int item in hashset)
			{
				Console.WriteLine(item);
			}
		}
	}
}