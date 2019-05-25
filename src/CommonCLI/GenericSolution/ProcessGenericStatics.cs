using CommonCLI.Interface;
using System;

namespace CommonCLI.GenericSolution
{
	public class ProcessGenericStatics : IGenericProcess
	{
		public void Run()
		{
			var a = new Item<int>();
			var b = new Item<int>();
			var c = new Item<string>();

			Console.WriteLine($"Item<int> count : {Item<int>.InstanceCount}");
			Console.WriteLine($"Item<string> count : {Item<string>.InstanceCount}");
			Console.WriteLine($"Item<double> count : {Item<double>.InstanceCount}");

			var d = new CommonItem<int>();
			var e = new CommonItem<int>();
			var f = new CommonItem<string>();

			Console.WriteLine($"CommonItem<int> count : {CommonItem.InstanceCount}");
			Console.WriteLine($"CommonItem<string> count : {CommonItem.InstanceCount}");
			Console.WriteLine($"CommonItem<double> count : {CommonItem.InstanceCount}");
		}

		public class Item<T>
		{
			public static int InstanceCount;

			public Item()
			{
				InstanceCount += 1;
			}
		}

		public class CommonItem<T> : CommonItem
		{

		}

		public class CommonItem
		{
			public static int InstanceCount;

			public CommonItem()
			{
				InstanceCount += 1;
			}
		}
	}
}
