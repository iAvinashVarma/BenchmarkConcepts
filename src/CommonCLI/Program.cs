using CommonCLI.Enums;

namespace CommonCLI
{
	class Program
	{
		static void Main(string[] args)
		{
			GenericsFactory.Instance.Run(ProcessType.Stack);
		}
	}
}
