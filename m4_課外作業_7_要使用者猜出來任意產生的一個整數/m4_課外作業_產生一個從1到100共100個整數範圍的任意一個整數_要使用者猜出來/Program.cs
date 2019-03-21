using System;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		int umep;//從1到100共100個整數範圍的任意一個整數
				 // fix #1 觀察下一行
				 // 產生一個從1到100共100個整數範圍的任意一個整數
		umep = (int)(new Random().NextDouble() * 100 + 1);
		Console.WriteLine("umep   為");
		Console.WriteLine(umep);

		Console.WriteLine("#################################################");
		String 使用者的輸入;
		bool 使用者輸入的是int;

		// fix #2 觀察下面 while 迴圈
		// fix #3  修改下面 while 迴圈, 使得使用者可比較容易猜出答案.
		//           若猜太大了, 請提示使用者往小一點的方向猜
		//           若猜太小了, 請提示使用者往大一點的方向猜
		//           若猜錯了, 讓使用者繼續猜
		//           若猜對了, 才離開此while, 才可結束程式
		while (true)
		{
			Console.WriteLine();
			Console.WriteLine("請輸入一個從1到100的整數");
			使用者的輸入 = Console.ReadLine();
			// fix #4 觀察下面 TryParse 
			//   , 它可把使用者輸入的字串, 轉成整數存到 "使用者猜的整數" 變數中.
			//   若轉成功, 會算出 true
			//   若轉不成功, 會算出 false
			使用者輸入的是int = int.TryParse(使用者的輸入, out var 使用者猜的整數);
			if (使用者輸入的是int)
			{
				Console.WriteLine("使用者猜的整數     為");
				Console.WriteLine(使用者猜的整數);

				var delta = umep - 使用者猜的整數;

				if (delta < -20)
					Console.WriteLine("猜太大了，請往小的方向猜");
				else if (delta < 0)
					Console.WriteLine("快接近了，請往小的方向猜");
				else if (delta > 20)
					Console.WriteLine("猜太小了，請往大的方向猜");
				else if (delta > 0)
					Console.WriteLine("快接近了，請往大的方向猜");
				else if (delta == 0)
				{
					Console.WriteLine("正確答案");
					break;
				}
			}
			else
				Console.WriteLine("請輸入數字！");

		} // end of 迴圈 while
		Console.WriteLine("遊戲結束");
	}
}

