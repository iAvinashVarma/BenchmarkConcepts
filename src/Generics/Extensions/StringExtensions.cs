using System;

namespace Generics.Extensions
{
	public static class StringExtensions
	{
		public static TEnum ParseEnum<TEnum>(this string value) where TEnum : struct, IConvertible
		{
			return (TEnum)Enum.Parse(typeof(TEnum), value);
		}
	}
}
