using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace 
{
	public class Mathematics
	{

		static int CountDigits(int n)
		{
			int count=0;
			while(n!=0)
			{
				n/=10;
				count++;
			}
			return count;
		}

		public static void Main(string[] args)
		{
			Console.WriteLine(CountDigits(917229));
		}
	}
}