namespace CommonCLI.Interface
{
	public interface IDepartmentCollection<TEntity>
	{
		IDepartmentCollection<TEntity> Add(string departmentName, TEntity entity);
	}
}
