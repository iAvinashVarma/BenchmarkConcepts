using Generics.Delegates;
using Generics.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Generics.Extensions
{
	public static class BufferExtensions
	{
		public static void Dump<T>(this IBuffer<T> buffer, Printer<T> print)
		{
			foreach (var item in buffer)
			{
				print(item);
			}
		}

		public static IEnumerable<TOut> AsEnumerableOf<TIn, TOut>(this IBuffer<TIn> buffer)
		{
			TypeConverter converter = TypeDescriptor.GetConverter(typeof(TIn));
			foreach (TIn item in buffer)
			{
				TOut result = (TOut)converter.ConvertTo(item, typeof(TOut));
				yield return result;
			}
		}
	}
}
