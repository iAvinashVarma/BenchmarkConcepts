namespace CommonCLI.Interface
{
	public interface IDepartmentCollection<TCol, TEnt>
	{
		TCol Add(string departmentName, TEnt entity);
	}
}
