using Generics.Interface;
using Generics.Ioc;
using Generics.Model;
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

		[Test]
		public void Can_Resolve_Types_Without_Default_Ctor()
		{
			Container ioc = new Container();
			ioc.For<ILogger>().Use<SqlServerLogger>();
			ioc.For<IRepository<Employee>>().Use<SqlRepository<Employee>>();

			object repository = ioc.Resolve<IRepository<Employee>>();
			Assert.AreEqual(typeof(SqlRepository<Employee>), repository.GetType());
		}
	}
}
