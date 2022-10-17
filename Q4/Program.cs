using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			int year = today.Year;
			int month = today.Month;
			DateTime endOfMonth = new DateTime(year, month+1, 1).AddDays(-1);
			Console.WriteLine(endOfMonth);
		}
	}
}
