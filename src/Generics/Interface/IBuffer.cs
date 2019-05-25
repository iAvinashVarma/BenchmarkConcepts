using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Interface
{
	public interface IBuffer<T> : IEnumerable<T>
	{
		int Capacity { get; }

		bool IsEmpty { get; }

		void Write(T value);

		T Read();
	}
}
