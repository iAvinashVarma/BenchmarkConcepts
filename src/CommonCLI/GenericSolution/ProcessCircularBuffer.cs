using Generics;
using Generics.Concrete;

namespace CommonCLI.GenericSolution
{
	public class ProcessCircularBuffer : ProcessBuffer
	{
		public override void Run()
		{
			var buffer = new CircularBuffer<double>(capacity: 3);
			DoInput(buffer);
			OutputBuffer(buffer);
			DoBuffer(buffer);
		}
	}
}
