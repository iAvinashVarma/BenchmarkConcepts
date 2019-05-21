using System;
using System.Linq;

namespace Generics.DataAccess.Interface
{
	public interface IRepository<T> : IDisposable
	{
		void Add(T entity);

		void Delete(T entity);

		T FindById(int id);

		IQueryable<T> FindAll();

		int Commit();
	}
}
