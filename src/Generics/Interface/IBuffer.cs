using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Interface
{
	public interface IBuffer<T> : IEnumerable<T>
	{
		bool IsEmpty { get; }

		void Write(T value);

		IEnumerable<TOut> AsEnumerableOf<TOut>();

		T Read();
	}
}
