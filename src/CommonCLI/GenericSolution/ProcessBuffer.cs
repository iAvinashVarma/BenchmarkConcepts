using CommonCLI.Interface;
using Generics.Concrete;
using Generics.Extensions;
using Generics.Interface;
using Generics.Miscellaneous;
using System;

namespace CommonCLI.GenericSolution
{
	public class ProcessBuffer : IGenericProcess
	{
		public virtual void Run()
		{
			Buffer<double> buffer = new Buffer<double>();
			DoInput(buffer);
			OutputBuffer(buffer);
			DoBuffer(buffer);
		}

		public virtual void OutputBuffer(IBuffer<double> buffer)
		{
			buffer.Map(d => DateTime.Now.AddDays(d)).ForEach(x => Console.WriteLine(x));
		}

		public virtual void DoBuffer(IBuffer<double> buffer)
		{
			double sum = 0.0d;
			Console.WriteLine("Buffer: ");
			while (!buffer.IsEmpty)
			{
				sum += buffer.Read();
			}
			Console.WriteLine(sum);
		}

		public virtual void DoInput(IBuffer<double> buffer)
		{
			int occurance = 0;
			while (true)
			{
				occurance++;
				if(occurance > buffer.Capacity)
				{
					break;
				}
				bool success = Reader.TryReadLine(out string input, 5000);
				if (!success)
				{
					input = new Random().NextDouble(1.1, 9.5).ToString();
					Console.WriteLine($"Auto Input : {input}.");
				}
				else
				{
					Console.WriteLine($"Given Input : {input}.");
				}
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
