using Generics.Model;
using System;
using System.Collections.Generic;

namespace CommonCLI.Compare
{
	public class EmployeeComparer : IEqualityComparer<Employee>, IComparer<Employee>
	{
		public int Compare(Employee x, Employee y) => string.Compare(x.Name, y.Name);

		public bool Equals(Employee x, Employee y) => string.Equals(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);

		public int GetHashCode(Employee obj) => obj.Name.GetHashCode();
	}
}
