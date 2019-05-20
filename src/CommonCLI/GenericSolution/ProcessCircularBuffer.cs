using Generics;
using Generics.Concrete;
using Generics.Events;
using System;

namespace CommonCLI.GenericSolution
{
	public class ProcessCircularBuffer : ProcessBuffer
	{
		public override void Run()
		{
			var buffer = new CircularBuffer<double>(capacity: 3);
			buffer.ItemDiscarded += ItemDiscarded;
			DoInput(buffer);
			OutputBuffer(buffer);
			DoBuffer(buffer);
		}

		private void ItemDiscarded(object sender, ItemDiscardedEventArgs<double> e)
		{
			Console.WriteLine($"Buffer full. Discarding {e.ItemDiscarded}, New item is {e.NewItem}.");
		}
	}
}
