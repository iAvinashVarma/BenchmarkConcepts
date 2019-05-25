using CommonCLI.Enums;
using CommonCLI.Interface;
using Generics.Extensions;
using System;

namespace CommonCLI.GenericSolution
{
	public class ProcessGenericEnum : IGenericProcess
	{
		public void Run()
		{
			string input = "Step1";
			var step = input.ParseEnum<Steps>();
			Console.WriteLine(step);
		}
	}
}