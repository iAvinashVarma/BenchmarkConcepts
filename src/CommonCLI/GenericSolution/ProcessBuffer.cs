﻿using CommonCLI.Interface;
using Generics;
using Generics.Interface;
using System;

namespace CommonCLI.GenericSolution
{
	public class ProcessBuffer : IGenericProcess
	{
		public virtual void Run()
		{
			var buffer = new Buffer<double>();
			DoInput(buffer);
			DoBuffer(buffer);
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