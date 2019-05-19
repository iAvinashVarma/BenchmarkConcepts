using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Tests
{
	[TestFixture]
	public class StackTests
	{
		[Test]
		public void Can_Peek_At_Next_Time()
		{
			var stack = new Stack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			Assert.AreEqual(3, stack.Peek());
		}

		[Test]
		public void Can_Search_With_Contains()
		{
			var stack = new Stack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			Assert.IsTrue(stack.Contains(2));
		}

		[Test]
		public void Can_Concert_Queue_To_Array()
		{
			var stack = new Stack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			var asArray = stack.ToArray();
			stack.Pop();

			Assert.AreEqual(3, asArray[0]);
			Assert.AreEqual(2, stack.Count);
		}
	}
}
