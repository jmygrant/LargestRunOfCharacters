using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeTest
{
	class Program
	{
		public static int IndexOfLongestRun(string str)
		{
			if(string.IsNullOrEmpty(str))
			{
				return -1;
			}
			string longestRun = new string(str.Select((c, index) => str.Substring(index).TakeWhile(e => e == c))
								   .OrderByDescending(e => e.Count())
								   .First().ToArray());
			int indexOfLongest = str.IndexOf(longestRun);
			return indexOfLongest;
		}

		public static void Main(string[] args)
		{
			Console.WriteLine(IndexOfLongestRun("abbcccddddcccbba"));
			Console.ReadLine();
		}
	}
}
