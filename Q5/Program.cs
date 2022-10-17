using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//先輸入年分，並找到此年的第一天
			Console.Write("輸入西元年: ");
			int year = Convert.ToInt32(Console.ReadLine());
			DateTime firstDayOfYear = new DateTime(year, 1, 1);

			//計算離第一個星期日還差幾天
			int value = (int)firstDayOfYear.DayOfWeek;
			int beforeSunday = (value > 0) ? 7 - value : 0;

			//算出第一個星期日的日期
			DateTime firstSunday = new DateTime(year, 1, 1+beforeSunday);
			
			//以迴圈每次+7天的方式算出後續日期
			//加的日期不能超過今年
			Console.WriteLine($"{year}年的星期日羅列如下: ");
			bool leapYear = DateTime.IsLeapYear(year);
			int daysInYear = (leapYear) ? 366 : 365;
			const int daysInWeek = 7;
			for (int i = 0; i < daysInYear-beforeSunday; i += daysInWeek)
			{
				DateTime nextSunday = firstSunday.AddDays(i);
				//此段在i上限值未設置正確時使用
				//if (nextSunday.Year != year)
				//{
				//	break;
				//}
				Console.WriteLine(nextSunday.ToString("yyyy/MM/dd"));
			}

		}
	}
}
