namespace Generics.Constants
{
	public static class Line
	{
		public static readonly string Star = string.Empty;

		public static readonly string Hyphen = string.Empty;

		static Line()
		{
			Star = new string('*', 25);
			Hyphen = new string('-', 25);
		}
	}
}
