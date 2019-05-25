using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics.Extensions
{
	public static class EnumExtensions
	{
		public static IEnumerable<T> GetValues<T>() where T : struct, IConvertible
		{
			return Enum.GetValues(typeof(T)).Cast<T>();
		}
	}
}
