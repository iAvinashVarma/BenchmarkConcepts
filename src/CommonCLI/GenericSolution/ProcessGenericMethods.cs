using CommonCLI.Interface;
using Generics.Model;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CommonCLI.GenericSolution
{
	public class ProcessGenericMethods : IGenericProcess
	{
		public void Run()
		{
			object employeeList = CreateCollection(typeof(List<>), typeof(Employee));
			Console.WriteLine(employeeList.GetType().Name);
			Type[] genericArguments = employeeList.GetType().GenericTypeArguments;
			foreach (Type arg in genericArguments)
			{
				Console.WriteLine($"[{arg.Name}]");
			}

			Employee employee = new Employee();
			Type employeeType = typeof(Employee);
			MethodInfo methodInfo = employeeType.GetMethod("Speak");
			methodInfo = methodInfo.MakeGenericMethod(typeof(DateTime));
			methodInfo.Invoke(employee, null);
		}

		private object CreateCollection(Type collectionType, Type itemType)
		{
			Type closedType = collectionType.MakeGenericType(itemType);
			return Activator.CreateInstance(closedType);
		}
	}
}