using System;

namespace EnvironmentVariableGet
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("■環境変数");

			Console.WriteLine($"OS         = {Environment.GetEnvironmentVariable("OS")}");
			Console.WriteLine($"PATHEXT    = {Environment.GetEnvironmentVariable("PATHEXT")}");
			Console.WriteLine($"TEST_VALUE = {Environment.GetEnvironmentVariable("TEST_VALUE")}");

			Console.WriteLine("いずれかのキーを押して終了してください。");
			Console.ReadKey();
		}
	}
}
