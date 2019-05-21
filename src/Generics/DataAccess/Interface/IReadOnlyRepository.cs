using System;
using System.Linq;

namespace Generics.DataAccess.Interface
{
	public interface IReadOnlyRepository<out T> : IDisposable
	{
		T FindById(int id);

		IQueryable<T> FindAll();
	}
}
