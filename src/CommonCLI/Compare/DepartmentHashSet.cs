using CommonCLI.Interface;
using Generics.Model;
using System.Collections.Generic;
using System.Linq;

namespace CommonCLI.Compare
{
	public class DepartmentHashSet : SortedDictionary<string, HashSet<Employee>>, IDepartmentCollection<Employee>, IDepartmentEnumerable<string, Employee>
	{
		public SortedDictionary<string, HashSet<Employee>> Departments
		{
			get { return this; }
		}

		public IDepartmentCollection<Employee> Add(string departmentName, Employee entity)
		{
			if (!ContainsKey(departmentName))
			{
				Add(departmentName, new HashSet<Employee>(new EmployeeComparer()));
			}
			this[departmentName].Add(entity);
			return this;
		}

		IEnumerator<KeyValuePair<string, IEnumerable<Employee>>> IEnumerable<KeyValuePair<string, IEnumerable<Employee>>>.GetEnumerator()
		{
			var items = Departments.Select(x => new KeyValuePair<string, IEnumerable<Employee>>(key: x.Key, value: x.Value));
			foreach (var item in items)
			{
				yield return item;
			}
		}
	}
}
