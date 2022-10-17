using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime date = DateTime.Today;
			int day = date.Day;
			if(day <= 10)
			{
				Console.WriteLine("今天是本月的上旬");
			}else if(day <= 20){
				Console.WriteLine("今天是本月的中旬");
			}
			else
			{
				Console.WriteLine("今天是本月的下旬");
			}

		}
	}
}
