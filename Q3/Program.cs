using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "1213213A";
			int result = value.ToInt(6);
			Console.WriteLine(result);

		}

	}
	public static class extensions
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool str = Int32.TryParse(value, out int val);
			if (str!=true) return defaultValue;
			return val;
		}
	}
}
