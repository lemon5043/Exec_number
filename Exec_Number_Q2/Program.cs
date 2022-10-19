using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Number_Q2
{
	internal class Program
	{
		static bool isPrime(int num)
		{
			//初始條件
			if (num < 2)
			{
				return false;
			}

			if (num % 2 == 0 && num != 2)
			{
				return false;
			}

			int n = 3;
			while (n <= Math.Sqrt(num))
			{
				if (num % n == 0)
				{
					return false;
				}
				else
				{
					n += 2;
				}
			}

			return true;
		}
		static void Main(string[] args)
		{
			//找出數值區間間的所有質數
			Console.Write("請輸入一個正整數:");
			string input1 = Console.ReadLine();
			Console.Write("請輸入一個比剛剛還要大的正整數");
			string input2 = Console.ReadLine();

			bool isInt1 = int.TryParse(input1, out int min);
			bool isInt2 = int.TryParse(input2, out int max);
			
			// 初始條件
			if (!isInt1 || !isInt2 ||min >= max)
			{
				Console.WriteLine("請按照正確指示操作");
			}

			for (int i = min; i <= max; i++)
			{
				if (isPrime(i))
				{
					Console.WriteLine(i);
				}
			}

		}
	}
}
