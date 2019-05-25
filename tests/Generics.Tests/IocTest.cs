using Generics.Interface;
using Generics.Ioc;
using NUnit.Framework;

namespace Generics.Tests
{
	[TestFixture]
	public class IocTest
	{
		[Test]
		public void Can_Resolve_Type()
		{
			Container ioc = new Container();
			ioc.For<ILogger>().Use<SqlServerLogger>();

			object logger = ioc.Resolve<ILogger>();
			Assert.AreEqual(typeof(SqlServerLogger), logger.GetType());
		}
	}
}
