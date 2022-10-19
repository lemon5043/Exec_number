using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入一個整數:");
			string input = Console.ReadLine();
			bool isInt = int.TryParse(input, out int num);

				//初始條件
			if (!isInt)
			{
				Console.WriteLine("無效數字，請再試一次");
				return;
			} else if (num <= 1)
				// 0、1及負數皆非質數也不是合數
			{
				Console.WriteLine("此數非質數也非合數");
				return;
			} else if (num % 2 == 0 && num != 2)
				// num能被2的倍數整除就一定能被2整除，因此不需放在迴圈裡增加時間複雜度
			{
				Console.WriteLine(num + "並非質數");
				return;
			}

				int n = 3;
			while (n <= Math.Sqrt(num))
			{
				if (num % n == 0)
				{
					Console.WriteLine(num + "並非質數");
					return;
				}
				else
				{
					n +=2;
				}
			}

			Console.WriteLine(num + "為質數");
		}
	}
}
