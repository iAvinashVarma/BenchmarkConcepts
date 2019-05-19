using CommonCLI.Interface;
using Generics;
using Generics.Interface;
using System;

namespace CommonCLI.GenericSolution
{
	public class ProcessCircularBuffer : IGenericProcess
	{
		public void Run()
		{
			var buffer = new CircularBuffer<double>(capacity: 3);
			ProcessInput(buffer);
			ProcessBuffer(buffer);
		}

		private void ProcessBuffer(IBuffer<double> buffer)
		{
			double sum = 0.0d;
			Console.WriteLine("Buffer: ");
			while (!buffer.IsEmpty)
			{
				sum += buffer.Read();
			}
			Console.WriteLine(sum);
		}

		private void ProcessInput(IBuffer<double> buffer)
		{
			while (true)
			{
				Console.WriteLine("Enter number");
				var input = Console.ReadLine();
				if (double.TryParse(input, out double value))
				{
					buffer.Write(value);
					continue;
				}
				break;
			}
		}
	}
}
