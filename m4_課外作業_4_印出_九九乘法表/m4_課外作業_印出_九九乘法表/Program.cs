using System;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("開始");
		Console.ForegroundColor = ConsoleColor.Yellow;
		// fix #1    印出 九九乘法表
		//  煩請用 while 做出來
		//Console.WriteLine("1x1= 1 1x2= 2 1x3= 1     .....    1x7= 7 1x8= 8 1x9= 9 ");
		//Console.WriteLine("2x1= 2 2x2= 4 2x3= 6     .....    2x7=14 2x8=16 2x9=18 ");
		//Console.WriteLine("3x1= 3 3x2= 6 3x3= 9     .....    3x7=21 3x8=24 3x9=27 ");

		var i = 0;
		var j = 0;
		while (++i < 10)
		{
			while (++j < 10)
				Console.Write($"{i}x{j}={i * j,2} ");

			Console.WriteLine();
			j = 0;
		}

		Console.WriteLine();
		Console.ResetColor();
		Console.WriteLine("結束");
	}
}
