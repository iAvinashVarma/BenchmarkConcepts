using CommonCLI.Compare;
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
				case ProcessType.Buffer:
					genericProcess = new ProcessBuffer();
					break;
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
				case ProcessType.Dictionary:
					genericProcess = new ProcessDictionary();
					break;
				case ProcessType.Sort:
					genericProcess = new ProcessSort();
					break;
				case ProcessType.ComparingEmployees:
					genericProcess = new ProcessComparingEmployees();
					break;
				case ProcessType.Delegates:
					genericProcess = new ProcessDelegates();
					break;
				case ProcessType.Constraints:
					genericProcess = new ProcessConstraints();
					break;
				case ProcessType.GenericMethods:
					genericProcess = new ProcessGenericMethods();
					break;
				case ProcessType.IocContainer:
					genericProcess = new ProcessIocContainer();
					break;
				case ProcessType.GenericEnum:
					genericProcess = new ProcessGenericEnum();
					break;
				case ProcessType.BaseTypes:
					genericProcess = new ProcessBaseTypes();
					break;
				case ProcessType.GenericStatics:
					genericProcess = new ProcessGenericStatics();
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
