using CommonCLI.DataStructure;
using CommonCLI.Enums;
using CommonCLI.GenericSolution;
using CommonCLI.Interface;

namespace CommonCLI
{
	public class GenericsFactory : SingletonBase<GenericsFactory>
	{
		public IGenericProcess GetGenericProcess(ProcessType processType)
		{
			IGenericProcess genericProcess = null;
			switch (processType)
			{
				case ProcessType.CircularBuffer:
					genericProcess = new ProcessCircularBuffer();
					break;
				case ProcessType.Array:
					genericProcess = new ProcessArray();
					break;
				case ProcessType.List:
					genericProcess = new ProcessList();
					break;
				case ProcessType.Queue:
					genericProcess = new ProcessQueue();
					break;
				case ProcessType.Stack:
					genericProcess = new ProcessStack();
					break;
				case ProcessType.HashSet:
					genericProcess = new ProcessHashSet();
					break;
				case ProcessType.LinkedList:
					genericProcess = new ProcessLinkedList();
					break;
				default:
					break;
			}
			return genericProcess;
		}

		public void Run(ProcessType processType)
		{
			GetGenericProcess(processType).Run();
		}
	}
}
