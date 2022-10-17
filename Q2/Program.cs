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
			DateTime today = DateTime.Today;
			DateTime deadline = today.AddMonths(1);
			Console.WriteLine($"您的圖書應於{deadline:M}歸還");
		}
	}
}
