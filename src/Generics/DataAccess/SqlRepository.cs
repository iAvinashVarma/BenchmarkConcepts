using Generics.DataAccess.Interface;
using System;
using System.Data.Entity;
using System.Linq;

namespace Generics.DataAccess
{
	public class SqlRepository<T> : IRepository<T> where T : class, IEntity
	{
		private readonly DbContext _dbContext;
		private readonly DbSet<T> _dbSet;

		public SqlRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
			_dbSet = _dbContext.Set<T>();
		}

		public void Add(T entity)
		{
			if (entity.IsValid())
			{
				_dbSet.Add(entity);
			}
		}

		public int Commit()
		{
			return _dbContext.SaveChanges();
		}

		public void Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			_dbContext.Dispose();
		}

		public IQueryable<T> FindAll()
		{
			return _dbSet;
		}

		public T FindById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
