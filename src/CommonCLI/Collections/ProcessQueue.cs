using CommonCLI.Interface;
using Generics.Model;
using System;
using System.Collections.Generic;

namespace CommonCLI.Collections
{
	public class ProcessQueue : IGenericProcess
	{
		public void Run()
		{
			var employeesLine = new Queue<Employee>();
			employeesLine.Enqueue(new Employee { Name = "Steve" });
			employeesLine.Enqueue(new Employee { Name = "Charles" });
			employeesLine.Enqueue(new Employee { Name = "Lary" });

			while (employeesLine.Count > 0)
			{
				var employee = employeesLine.Dequeue();
				Console.WriteLine(employee.Name);
			}
		}
	}
}
