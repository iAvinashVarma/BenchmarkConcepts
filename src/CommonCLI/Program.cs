namespace CommonCLI
{
	class Program
	{
		static void Main(string[] args)
		{
			var processType = ProcessType.List;
			switch (processType)
			{
				case ProcessType.CircularBuffer:
					ProcessCircularBuffer.Instance.Run();
					break;
				case ProcessType.Array:
					ProcessArray.Instance.Run();
					break;
				case ProcessType.List:
					ProcessList.Instance.Run();
					break;
				default:
					break;
			}
		}
	}
}
