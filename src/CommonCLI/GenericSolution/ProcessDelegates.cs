using CommonCLI.Interface;
using System;

namespace CommonCLI.GenericSolution
{
	public class ProcessDelegates : IGenericProcess
	{
		public void Run()
		{
			Action<bool> print = p => Console.WriteLine(p);
			Func<double, double> square = d => d * d;
			Func<double, double, double> add = (x, y) => x + y;
			Predicate<double> isOdd = n => n % 2 != 0;
			print(isOdd(square(add(3, 6))));
		}
	}
}
