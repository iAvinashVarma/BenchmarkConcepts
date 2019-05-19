using CommonCLI.Interface;
using System;
using System.Collections.Generic;

namespace CommonCLI.DataStructure
{
	public class ProcessLinkedList : IGenericProcess
	{
		public void Run()
		{
			LinkedListInt();
		}

		private static void LinkedListInt()
		{
			LinkedList<int> linkedList = new LinkedList<int>();
			linkedList.AddFirst(2);
			linkedList.AddFirst(3);

			LinkedListNode<int> first = linkedList.First;
			linkedList.AddAfter(first, 5);
			linkedList.AddBefore(first, 10);

			foreach (int item in linkedList)
			{
				Console.WriteLine(item);
			}

			while (first != null)
			{
				Console.WriteLine(first.Value);
				first = first.Next;
			}
		}
	}
}