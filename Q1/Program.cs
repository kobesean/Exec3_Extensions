using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("輸入整字");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("請輸入內容");
				return;
			}
			bool str = Int32.TryParse(input, out int val);
			if (str != true)
			{
				Console.WriteLine("請輸入整數");
				return ;
			}
			int value=int.Parse(input);
			
			//bool isOdd = number(value, num => num % 2 == 1);
			bool isEven = number(value, num => num % 2 == 0);
			if (isEven==true)
			{
				Console.WriteLine("輸入數字是偶數");
			}
			else
			{
				Console.WriteLine("輸入數字是奇數");
			}
			

		}
		static bool number(int num, Func<int, bool> func)
		{
			return func(num);
		}
	}

}
