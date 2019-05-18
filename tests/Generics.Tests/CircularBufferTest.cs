using NUnit.Framework;
using System.Linq;

namespace Generics.Tests
{
	[TestFixture]
	public class CircularBufferTest
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void New_Buffer_Is_Empty()
		{
			var buffer = new CircularBuffer<double>();
			Assert.IsTrue(buffer.IsEmpty);
		}

		[Test]
		public void Three_Element_Buffer_Is_Full_After_Three_Writes()
		{
			var buffer = new CircularBuffer<double>(capacity: 3);
			buffer.Write(1);
			buffer.Write(1);
			buffer.Write(1);
			Assert.IsTrue(buffer.IsFull);
		}

		[Test]
		public void First_In_First_Out_When_Not_Full()
		{
			var buffer = new CircularBuffer<double>(capacity: 3);
			var valueOne = 1.1d;
			var valueTwo = 2.0d;
			buffer.Write(valueOne);
			buffer.Write(valueTwo);

			Assert.AreEqual(valueOne, buffer.Read());
			Assert.AreEqual(valueTwo, buffer.Read());
			Assert.IsTrue(buffer.IsEmpty);
		}

		[Test]
		public void Overwrites_When_More_Than_Capacity()
		{
			var buffer = new CircularBuffer<double>(capacity: 3);
			var values = Enumerable.Range(1, 5).Select(x => (double)x).ToArray();

			foreach (var value in values)
			{
				buffer.Write(value);
			}

			Assert.IsTrue(buffer.IsFull);
			Assert.AreEqual(values[2], buffer.Read());
			Assert.AreEqual(values[3], buffer.Read());
		}
	}
}