using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics.Tests
{
	[TestFixture]
	public class ListTests
	{
		[Test]
		public void A_List_Can_Insert()
		{
			var integers = new List<int> { 1, 2, 3 };
			integers.Insert(1, 6);
			Assert.AreEqual(6, integers[1]);
		}

		[Test]
		public void A_List_Can_Remove()
		{
			var integers = new List<int> { 1, 2, 3 };
			integers.Remove(2);
			Assert.IsTrue(integers.SequenceEqual(new[] { 1, 3 }));
		}

		public void A_List_Can_Find_Things()
		{
			var integers = new List<int> { 1, 2, 3 };
			Assert.AreEqual(integers.IndexOf(3), 2);
		}
	}
}
