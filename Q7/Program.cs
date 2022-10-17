using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			int hour = now.Hour;
			//hour = 12; //測試用
			if(hour < 6 || hour >= 18)
			{
				Console.WriteLine("晚上好");
			}else if(hour < 11)
			{
				Console.WriteLine("早上好");
			}else if (hour < 13)
			{
				Console.WriteLine("中午好，吃飯了嗎?");
			}
			else
			{
				Console.WriteLine("下午好");
			}
		}
	}
}
