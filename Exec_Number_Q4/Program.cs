using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Number_Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//100元買100隻雞，公雞5元、母雞3元、小雞3隻1元 公雞Cock 母雞Hen 小雞Chicken
			int cock = 5;
			int hen = 3;
			decimal chicken =(decimal) 1 / 3;
			// int a;
			// int b;
			// int c;
			// a+b+c = 100
			// 5a+3b+(1/3)c=100
			for (int i = 0; i < 100; i++)
			{
				for (int j = 0; j < 100; j++)
				{
					int k = 100 - i - j;

					if (cock * i + hen * j + chicken * k == 100 && k % 3 == 0) 
					{
						Console.WriteLine($"共{i}隻公雞、{j}隻母雞、{k}隻小雞");
					} 
				}
			}
		}
	}
}
