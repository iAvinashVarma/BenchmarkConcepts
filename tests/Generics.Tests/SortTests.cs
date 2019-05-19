using NUnit.Framework;
using System.Collections.Generic;

namespace Generics.Tests
{
	[TestFixture]
	public class SortTests
	{
		[Test]
		public void Can_Use_Sorted_List()
		{
			SortedList<int, string> list = new SortedList<int, string>
			{
				{ 3, "Three" },
				{ 1, "One" },
				{ 2, "Two" }
			};

			Assert.AreEqual(0, list.IndexOfKey(1));
			Assert.AreEqual(1, list.IndexOfValue("Two"));
		}

		[Test]
		public void Can_Use_Sorted_Set()
		{
			SortedSet<int> set = new SortedSet<int>
			{
				3, 1, 2
			};

			SortedSet<int>.Enumerator enumerator = set.GetEnumerator();
			int i = 0;
			while (enumerator.MoveNext())
			{
				i += 1;
				Assert.AreEqual(enumerator.Current, i);
			}
		}
	}
}
