using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Tests
{
	[TestFixture]
	public class HashSetTests
	{
		[Test]
		public void Intersect_Sets()
		{
			var setOne = new HashSet<int>() { 1, 2, 3 };
			var setTwo = new HashSet<int>() { 2, 3, 4 };
			setOne.IntersectWith(setTwo);

			Assert.IsTrue(setOne.SetEquals(new[] { 2, 3 }));
		}

		[Test]
		public void Union_Sets()
		{
			var setOne = new HashSet<int>() { 1, 2, 3 };
			var setTwo = new HashSet<int>() { 2, 3, 4 };
			setOne.UnionWith(setTwo);

			Assert.IsTrue(setOne.SetEquals(new[] { 1, 2, 3, 4 }));
		}

		[Test]
		public void SymmetricExceptWith_Sets()
		{
			var setOne = new HashSet<int>() { 1, 2, 3 };
			var setTwo = new HashSet<int>() { 2, 3, 4 };
			setOne.SymmetricExceptWith(setTwo);

			Assert.IsTrue(setOne.SetEquals(new[] { 1, 4 }));
		}
	}
}
