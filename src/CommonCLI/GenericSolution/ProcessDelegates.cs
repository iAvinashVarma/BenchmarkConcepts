using CommonCLI.Interface;
using System;

namespace CommonCLI.GenericSolution
{
	public class ProcessDelegates : IGenericProcess
	{
		public void Run()
		{
			void print(bool p) => Console.WriteLine(p);
			double square(double d) => d * d;
			double add(double x, double y) => x + y;
			bool isOdd(double n) => n % 2 != 0;
			print(isOdd(square(add(3, 6))));
		}
	}
}
