using System;
using System.Drawing;
using System.Windows.Forms;

internal static class Program
{
	private static void Main()
	{

		// fix #9  
		//  之前第二個homework已示範展示了從左到右展現共 10 個按鈕(這樣算一層)
		//          煩請用 while 做出來 水平從左到右展現共10個按鈕
		//          但是要做 10 層
		Form f = new Form
		{
			Size = new Size(530, 530)
		};
		// fix #1 執行此程式, 觀察跑出的視窗上面有什麼?
		// fix #2 將下行註解取消, 再執行此程式, 觀察跑出的視窗上面有什麼?
		// fix #3 將下行的20改成60 , 再執行此程式, 觀察跑出的視窗上面有什麼?
		// fix #4 將下行的60改成100 , 再執行此程式, 觀察跑出的視窗上面有什麼?
		// fix #5 再將下行註解
		//Program.以xy座標加個按鈕到Form上(10, 20, f);

		// fix #7 已示範展示了從左到右展現共 3 個按鈕
		// ,煩請用 while 做出來 水平從左到右展現共10個按鈕

		var x = 0;
		var y = 0;

		while (++x < 10)
		{
			while (++y < 10)
				以xy座標加個按鈕到Form上(30 + x * 40, 40 + y * 40, f);

			y = 0;
		}

		// fix #8 再將下三行註解
		// fix #6 再將下三行註解取消
		//Program.以xy座標加個按鈕到Form上(10, 20 + 20, f);
		//Program.以xy座標加個按鈕到Form上(10, 20 + 60, f);
		//Program.以xy座標加個按鈕到Form上(10, 20 + 100, f);


		Application.Run(f);
	}

	private static Button 以xy座標加個按鈕到Form上(int x, int y, Form f)
	{
		Point location = new Point(x, y);
		Button b = new Button
		{
			Location = location,
			BackColor = Color.Yellow,
			Text = "炸",
			AutoSize = true,
			AutoSizeMode = AutoSizeMode.GrowAndShrink
		};
		f.Controls.Add(b);
		return b;
	}
}