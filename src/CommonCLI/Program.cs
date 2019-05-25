using CommonCLI.Enums;
using CommonCLI.Interface;
using Generics.Constants;
using Generics.Extensions;
using Generics.Model;
using System;

namespace CommonCLI
{
	internal class Program
	{
		private static void Main(string[] args)
		{
#if DEBUG
			DebugPreProcessor();
#else
			ReleasePreProcessor();
#endif
		}

		private static void ReleasePreProcessor()
		{
			foreach (ProcessType processType in EnumExtensions.GetValues<ProcessType>())
			{
				RunGenericProcess(processType);
			}
		}

		private static void DebugPreProcessor()
		{
			ProcessType processType = ProcessType.IocContainer;
			RunGenericProcess(processType);
		}

		private static void RunGenericProcess(ProcessType processType)
		{
			Console.WriteLine(Line.Star);
			Console.WriteLine($"--- {processType} ---");
			IGenericProcess genericProcess = GenericsFactory.Instance.GetGenericProcess(processType);
			genericProcess.Run();
			Console.WriteLine(Line.Star);
		}
	}
}
