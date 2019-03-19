using System;

namespace Tree
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			for (var i = 0; i < 5; i++)
			{
				for (var j = 4 - i; j > 0; j--)
					Console.Write(' ');
				for (var j = 0; j < i * 2 + 1; j++)
					Console.Write('*');
				Console.WriteLine();
			}
		}
	}
}
