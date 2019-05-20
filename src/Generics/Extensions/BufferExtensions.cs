using Generics.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Generics.Extensions
{
	public static class BufferExtensions
	{
		public static void Dump<T>(this IBuffer<T> buffer, Action<T> print)
		{
			foreach (T item in buffer)
			{
				print(item);
			}
		}

		public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
		{
			foreach (T item in enumerable)
			{
				action.Invoke(item);
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

		public static IEnumerable<TOut> Map<TIn, TOut>(this IBuffer<TIn> buffer, Converter<TIn, TOut> converter)
		{
			return buffer.Select(b => converter(b));
		}
	}
}
