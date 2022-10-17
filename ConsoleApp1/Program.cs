using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			DateTime deadline = today.AddDays(3);
			Console.WriteLine($"您的DVD應於{deadline:M}歸還");
		}
	}
}
