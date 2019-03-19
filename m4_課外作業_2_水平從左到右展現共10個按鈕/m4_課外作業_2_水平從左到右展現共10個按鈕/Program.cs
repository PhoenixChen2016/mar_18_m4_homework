using System;
using System.Drawing;
using System.Windows.Forms;

internal static class Program
{
	private static void Main()
	{
		Form f = new Form
		{
			Size = new Size(530, 530)
		};
		// fix #1 執行此程式, 觀察跑出的視窗上面有什麼?
		// fix #2 將下行註解取消, 再執行此程式, 觀察跑出的視窗上面有什麼?
		// fix #3 將下行的10改成190 , 再執行此程式, 觀察跑出的視窗上面有什麼?
		// fix #4 將下行的20改成220 , 再執行此程式, 觀察跑出的視窗上面有什麼?
		// fix #5 再將下行註解
		//Program.以xy座標加個按鈕到Form上(190, 220, f);

		// fix #9 已示範展示了從左到右展現共 3 個按鈕
		// ,煩請用 while 做出來 水平從左到右展現共10個按鈕

		//var i = 0;
		//while (i < 3)
		//{
		//	以xy座標加個按鈕到Form上(10 + 30 * i, 20, f);
		//	i++;
		//}

		// fix #6 將下行註解取消, 再執行此程式, 觀察跑出的視窗上面有什麼?
		//Program.以xy座標加個按鈕到Form上(10 + 20, 20, f);


		// fix #7 將下行註解取消, 再執行此程式, 觀察跑出的視窗上面有什麼?
		//Program.以xy座標加個按鈕到Form上(10 + 60, 20, f);


		// fix #8 將下行註解取消, 再執行此程式, 觀察跑出的視窗上面有什麼?
		//Program.以xy座標加個按鈕到Form上(10 + 100, 20, f);


		var i = 0;
		while (i < 10)
		{
			以xy座標加個按鈕到Form上(30 + 40 * i, 20, f);
			i++;
		}

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
