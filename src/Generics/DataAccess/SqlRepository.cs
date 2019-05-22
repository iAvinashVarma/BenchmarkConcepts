using Generics.DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Generics.DataAccess
{
	public class SqlRepository<T> : IRepository<T> where T : class, IEntity, new()
	{
		private readonly DbContext _dbContext;

		public SqlRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
			_dbContext.Database.EnsureDeleted();
			_dbContext.Database.EnsureCreated();
		}

		public void Add(T entity)
		{
			if (entity.IsValid())
			{
				_dbContext.Set<T>().Add(entity);
			}
		}

		public int Commit()
		{
			return _dbContext.SaveChanges();
		}

		public void Delete(T entity)
		{
			_dbContext.Set<T>().Remove(entity);
		}

		public void Dispose()
		{
			_dbContext.Dispose();
		}

		public IQueryable<T> FindAll()
		{
			return _dbContext.Set<T>();
		}

		public T FindById(int id)
		{
			return _dbContext.Set<T>().Find(id);
		}
	}
}
