using CommonCLI.Interface;
using Generics.Model;
using System;
using System.Collections.Generic;

namespace CommonCLI.DataStructure
{
	public class ProcessStack : IGenericProcess
	{
		public void Run()
		{
			var employeeStack = new Stack<Employee>();
			employeeStack.Push(new Employee { Name = "Steve" });
			employeeStack.Push(new Employee { Name = "Charles" });
			employeeStack.Push(new Employee { Name = "Lary" });

			while (employeeStack.Count > 0)
			{
				var employee = employeeStack.Pop();
				Console.WriteLine(employee.Name);
			}
		}
	}
}