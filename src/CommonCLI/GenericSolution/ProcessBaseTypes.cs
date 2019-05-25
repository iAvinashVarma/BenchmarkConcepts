using CommonCLI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonCLI.GenericSolution
{
	public class ProcessBaseTypes : IGenericProcess
	{
		public void Run()
		{
			var list = new List<Item>();
			list.Add(new Item<int>());
			list.Add(new Item<double>());
		}
	}

	public class Item<T> : Item
	{

	}

	public class Item
	{

	}
}