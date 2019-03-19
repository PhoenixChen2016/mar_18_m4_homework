using System;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("開始");
		int x;
		int y;
		//  fix #1  如何把 6 到15 共 拾 個整數, 判斷其是否為質數
		//    , 如果是質數, 把它印出來
		//  請寫在下面

		x = 6;

		if (IsPrime(x))
			Console.WriteLine($"{x}為質數");

		// 比如 x 為 6, 則用 2, 3, 4, 5  ( 即比 x 少 1 ) 當除數去除它, 若都無法整除
		//   , 則其為質數, 可惜2及3當除數去除它, 都可以整除

		y = 7;
		// 比如 y 為 7, 則用 2, 3, 4, 5, 6 ( 即比 y 少 1 ) 當除數去除它, 若都無法整除
		//   , 則其為質數, 結果真的都無法整除

		if (IsPrime(y))
			Console.WriteLine(y + "為質數");

		Console.WriteLine("結束");
	}

	private static bool IsPrime(int number)
	{
		var isPrime = true;
		for (var i = 2; i < number; i++)
		{
			if (number % i == 0)
			{
				isPrime = false;
				break;
			}
		}

		return isPrime;
	}
}