using CommonCLI.Interface;
using System;
using System.Linq;

namespace CommonCLI.GenericSolution
{
	public class ProcessMathProblem : IGenericProcess
	{
		public void Run()
		{
			double[] numbers = Enumerable.Range(1, 6).Select(r => (double)r).ToArray();
			double results = SampleNumbers(numbers);
			Console.WriteLine(results);
		}

		private double SampleNumbers(double[] numbers)
		{
			int count = 0;
			double sum = 0.0;
			for (int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
				count += 1;
			}
			return sum / count;
		}
	}
}
