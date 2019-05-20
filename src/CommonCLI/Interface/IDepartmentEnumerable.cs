using System.Collections.Generic;

namespace CommonCLI.Interface
{
	public interface IDepartmentEnumerable<TKey, TEntity> : IEnumerable<KeyValuePair<TKey, IEnumerable<TEntity>>>
	{
	}
}
