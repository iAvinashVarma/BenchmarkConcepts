using CommonCLI.Interface;
using Generics.Concrete;
using Generics.Extensions;
using Generics.Interface;
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
			DateTime converter(double d) => DateTime.Now.AddDays(d);
			buffer.Map(converter).ForEach(x => Console.WriteLine(x));
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
			while (true)
			{
				string input = Console.ReadLine();
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
