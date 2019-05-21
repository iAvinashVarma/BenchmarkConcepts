using System;
using System.Linq;

namespace Generics.DataAccess.Interface
{
	public interface IWriteOnlyRepository<in T> : IDisposable
	{
		void Add(T entity);

		void Delete(T entity);

		int Commit();
	}
}
