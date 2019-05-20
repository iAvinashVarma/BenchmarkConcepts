using Generics.Interface;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Generics.Concrete
{
	public class Buffer<T> : IBuffer<T>
	{
		protected Queue<T> _queue = new Queue<T>();

		public virtual bool IsEmpty => _queue.Count == 0;

		public IEnumerable<TOut> AsEnumerableOf<TOut>()
		{
			var converter = TypeDescriptor.GetConverter(typeof(T));
			foreach (var item in _queue)
			{
				var result = converter.ConvertTo(item, typeof(TOut));
				yield return (TOut)result;
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			foreach (var item in _queue)
			{
				yield return item;
			}
		}

		public virtual T Read() => _queue.Dequeue();

		public virtual void Write(T value) => _queue.Enqueue(value);

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
