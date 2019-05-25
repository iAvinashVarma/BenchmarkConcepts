using Generics.Interface;

namespace Generics.Ioc
{
	public class SqlRepository<T> : IRepository<T>
	{
		public SqlRepository(ILogger logger)
		{

		}
	}
}
