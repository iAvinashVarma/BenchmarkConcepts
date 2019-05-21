using Generics.DataAccess.Interface;
using System;

namespace Generics.Model
{
	public class Employee : Person, IEntity
	{
		public int DepartmentId { get; set; }

		public virtual void DoWork(Action<string> action)
		{
			action.Invoke("Doing real work.");
		}

		public bool IsValid()
		{
			return true;
		}
	}
}
