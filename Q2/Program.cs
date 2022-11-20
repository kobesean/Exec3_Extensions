using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "12132132";
			string result = extensions.Left(value, 5);
			Console.WriteLine(result);
			string result2 = value.Left(2);
			Console.WriteLine(result2);
		}
	}

	public static class extensions
	{
		public static string Left(this string aa , int length)
		{
			if (string.IsNullOrEmpty(aa))return string.Empty;
			if (aa.Length <= 0) return string.Empty;
			if (aa.Length<=length)return aa;
			return aa.Substring(0,length);
		}
	}
}
