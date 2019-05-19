using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Interface
{
	public interface IBuffer<T>
	{
		bool IsEmpty { get; }

		void Write(T value);

		T Read();
	}
}
