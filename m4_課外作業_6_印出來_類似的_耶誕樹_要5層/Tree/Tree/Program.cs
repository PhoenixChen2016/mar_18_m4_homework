using System;

namespace Tree
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var level = 6;

			for (var i = 0; i < level; i++)
			{
				for (var j = level - 1 - i; j > 0; j--)
					Console.Write(' ');
				for (var j = 0; j < i * 2 + 1; j++)
					Console.Write('*');
				Console.WriteLine();
			}
		}
	}
}
