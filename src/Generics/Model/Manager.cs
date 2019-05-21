using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Model
{
	public class Manager : Employee
	{
		public override void DoWork(Action<string> action)
		{
			action.Invoke("Create a meeting");
		}
	}
}
