using System;
using System.Threading;

namespace CiteTrack
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Hello World!!! " + DateTime.UtcNow);
			Thread.Sleep(1000);
		}
	}
}
