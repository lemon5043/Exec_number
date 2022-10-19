using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Number_Q3
{
	internal class Program
	{
		//有一個數值是四位數，左邊2位數字相同，右邊2位數字相同，這個四位數剛好是某整數的平方，請問是啥
		static bool Isqrt(int num)
		{
			if (Math.Sqrt(num) == Convert.ToInt32(Math.Sqrt(num)))
			{
				return true;
			}

			return false;
		}
		static void Main(string[] args)
		{
			//題目的數字一定會是11的倍數，若是用i++也可以，但此方法可降低時間複雜度
			for (int i = 1100; i < 10000; i += 11)
			{
				//11的倍數裡，若是左邊2個數相同，右邊2個數一定也相同，但這邊我們假裝不知道還是先列好條件
				if (i.ToString()[0] == i.ToString()[1] && i.ToString()[2] == i.ToString()[3] && Isqrt(i))
				{
					Console.WriteLine(i); //print 7744
				}
			}
		}
	}
}
