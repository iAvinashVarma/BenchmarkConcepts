using NUnit.Framework;
using System.Collections.Generic;

namespace Generics.Tests
{
	[TestFixture]
	public class DictionaryTests
	{
		[Test]
		public void Can_Use_Dictionary_As_Map()
		{
			Dictionary<int, string> map = new Dictionary<int, string>()
			{
				{1, "One" },
				{2, "Two" }
			};
			Assert.AreEqual("One", map[1]);
		}

		[Test]
		public void Can_Search_Key_With_Contains()
		{
			Dictionary<int, string> map = new Dictionary<int, string>()
			{
				{1, "One" },
				{2, "Two" }
			};
			Assert.IsTrue(map.ContainsKey(2));
		}

		[Test]
		public void Can_Remove_By_Key()
		{
			Dictionary<int, string> map = new Dictionary<int, string>()
			{
				{1, "One" },
				{2, "Two" }
			};
			map.Remove(1);
			Assert.AreEqual(1, map.Count);
		}
	}
}
