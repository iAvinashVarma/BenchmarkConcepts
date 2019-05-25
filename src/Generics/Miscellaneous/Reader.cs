using System;
using System.Threading;

namespace Generics.Miscellaneous
{
	public static class Reader
	{
		private static Thread inputThread;
		private static AutoResetEvent getInput, gotInput;
		private static string input;

		static Reader()
		{
			getInput = new AutoResetEvent(false);
			gotInput = new AutoResetEvent(false);
			inputThread = new Thread(ReadLineConsole)
			{
				IsBackground = true
			};
			inputThread.Start();
		}

		private static void ReadLineConsole()
		{
			while (true)
			{
				getInput.WaitOne();
				input = Console.ReadLine();
				gotInput.Set();
			}
		}

		public static string ReadLine(int timeOutMillisecs = Timeout.Infinite)
		{
			getInput.Set();
			bool success = gotInput.WaitOne(timeOutMillisecs);
			if (success)
			{
				return input;
			}
			else
			{
				throw new TimeoutException("User did not provide input within the timelimit.");
			}
		}

		public static bool TryReadLine(out string line, int timeOutMillisecs = Timeout.Infinite)
		{
			getInput.Set();
			bool success = gotInput.WaitOne(timeOutMillisecs);
			if (success)
			{
				line = input;
			}
			else
			{
				line = null;
			}

			return success;
		}
	}
}
