using Generics.Interface;
using System.Collections.Generic;

namespace Generics
{
	public class Buffer<T> : IBuffer<T>
	{
		Queue<T> _queue = new Queue<T>();

		public bool IsEmpty => _queue.Count == 0;

		public T Read() => _queue.Dequeue();

		public void Write(T value) => _queue.Enqueue(value);
	}
}
