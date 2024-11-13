using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingSkeleton.LapVaReNhanh
{
	public class VongLap
	{
		//1
		public void CheckDataType(string input)
		{
			if (int.TryParse(input, out int intValue))
			{
				Console.WriteLine("Giá trị là kiểu nguyên (int)");
			}
			else if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double doubleValue))
			{
				Console.WriteLine("Giá trị là kiểu số thực (double)");
			}
			else if (bool.TryParse(input, out bool boolValue))
			{
				Console.WriteLine("Giá trị là kiểu bool (boolean)");
			}
			else if (DateTime.TryParse(input, out DateTime dateValue))
			{
				Console.WriteLine("Giá trị là kiểu ngày tháng (DateTime)");
			}
			else
			{
				Console.WriteLine("Giá trị không thuộc kiểu nào trong các kiểu đã liệt kê");
			}
		}

		//2
		public void CheckDayOfDate(DateTime input)
		{
			var getDayOfWeek = input.DayOfWeek;
			switch(getDayOfWeek)
			{
				case DayOfWeek.Monday:
                    Console.WriteLine("Thu 2");
                    break;
				case DayOfWeek.Tuesday:
					Console.WriteLine("Thu 3");
					break;
				case DayOfWeek.Wednesday:
                    Console.WriteLine("Thu 4");
					break;
				case DayOfWeek.Thursday:
                    Console.WriteLine("Thu 5");
					break;
				case DayOfWeek.Friday:
                    Console.WriteLine("Thu 6");
					break;
				case DayOfWeek.Saturday:
                    Console.WriteLine("Thu 7");
					break;
				case DayOfWeek.Sunday:
                    Console.WriteLine("Chu nhat");
					break;
			}
		}

		//3
		public void PrintDate(DateTime input, int second)
		{
			while(second>0)
			{
                Console.WriteLine(input.ToString("dd/MM/yyyy"));
				input = input.AddDays(1);
				second--;
				Thread.Sleep(1000);
            }
		}

		//4
		public void PrintDay(DateTime input)
		{
			input = input.AddMonths(1);
			for(int i=0;i<10;i++)
			{
				input = input.AddDays(1);
                Console.WriteLine(input.ToString("dd/MM/yyyy"));
            }
		}

		//5 
		public void Print100Days(DateTime input)
		{
			for (int i = 0; i < 100; i++)
			{
				input = input.AddDays(1);
				if (input.DayOfWeek == DayOfWeek.Sunday)
					continue;
				Console.WriteLine($"Thu {input.DayOfWeek}," + input.ToString("dd/MM/yyyy"));
			}
		}
	}
}
