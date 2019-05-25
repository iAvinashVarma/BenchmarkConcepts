using Generics.Interface;
using Generics.Model;

namespace Generics.Ioc
{
	public class InvoiceService
	{
		public InvoiceService(IRepository<Employee> repository, ILogger logger)
		{

		}
	}
}
