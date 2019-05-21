using System;
using System.Linq;

namespace Generics.DataAccess.Interface
{
	public interface IRepository<T> : IReadOnlyRepository<T>, IWriteOnlyRepository<T>
	{
		
	}
}
