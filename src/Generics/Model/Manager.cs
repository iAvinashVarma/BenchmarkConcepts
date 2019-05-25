using System;

namespace Generics.Model
{
	public class Manager : Employee
	{
		public override void DoWork(Action<string> action)
		{
			if (action != null)
			{
				action.Invoke("Create a meeting");
			}
		}
	}
}
