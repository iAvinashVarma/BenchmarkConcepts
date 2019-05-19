using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Tests
{
	[TestFixture]
	public class QueueTests
	{
		[Test]
		public void Can_Peek_At_Next_Time()
		{
			var queue = new Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			Assert.AreEqual(1, queue.Peek());
		}

		[Test]
		public void Can_Search_With_Contains()
		{
			var queue = new Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			Assert.IsTrue(queue.Contains(2));
		}

		[Test]
		public void Can_Concert_Queue_To_Array()
		{
			var queue = new Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);

			var asArray = queue.ToArray();
			queue.Dequeue();

			Assert.AreEqual(1, asArray[0]);
			Assert.AreEqual(2, queue.Count);
		}
	}
}
