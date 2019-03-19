using System;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("開始");

		for (var x = 6; x <= 15; x++)
			if (IsPrime(x))
				Console.WriteLine($"{x}為質數");

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