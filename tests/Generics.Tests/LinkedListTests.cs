using NUnit.Framework;
using System.Collections.Generic;

namespace Generics.Tests
{
	[TestFixture]
	public class LinkedListTests
	{
		[Test]
		public void Can_Add_After()
		{
			var list = new LinkedList<string>();
			list.AddFirst("Hello");
			list.AddLast("World");
			list.AddAfter(list.First, "there");

			Assert.AreEqual("there", list.First.Next.Value);
		}

		[Test]
		public void Can_Remove_Last()
		{
			var list = new LinkedList<string>();
			list.AddFirst("Hello");
			list.AddLast("World");
			list.RemoveLast();

			Assert.AreEqual(list.First, list.Last);
		}

		[Test]
		public void Can_Find_Items()
		{
			var list = new LinkedList<string>();
			list.AddFirst("Hello");
			list.AddLast("World");

			Assert.IsTrue(list.Contains("Hello"));
		}
	}
}
