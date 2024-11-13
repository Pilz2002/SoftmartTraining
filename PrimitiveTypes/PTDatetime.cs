using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton.PrimitiveTypes
{
	public class PTDatetime
	{
		//1
		public void CurrentDate()
		{
			DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Hom nay la thu {currentTime.DayOfWeek},Thang {currentTime.Month}, Nam {currentTime.Year}");
        }

		//2
		public void CurrentDate(DateTime input)
		{
			Console.WriteLine($"Hom nay la thu {input.DayOfWeek},Thang {input.Month}, Nam {input.Year}");
		}

		//3
		public void NextDate()
		{
			DateTime currentTime = DateTime.Now;
			DateTime nextTime = currentTime.AddDays(1);
			Console.WriteLine($"Hom sau la thu {nextTime.DayOfWeek},Thang {nextTime.Month}, Nam {nextTime.Year}");
		}

		//4
		public void PreviousDate()
		{
			DateTime currentTime = DateTime.Now;
			DateTime previousTime = currentTime.AddDays(-1);
			Console.WriteLine($"Hom truoc la thu {previousTime.DayOfWeek},Thang {previousTime.Month}, Nam {previousTime.Year}");
		}

		//5
		public void CheckDate(DateTime input)
		{
			DateTime currentDate = DateTime.Now.Date;
			DateTime inputDate = input.Date;
			if( inputDate.CompareTo(currentDate) == 0)
			{
                Console.WriteLine("Ngay hom nay");
            }
			else if(inputDate.CompareTo(currentDate) < 0)
			{
                Console.WriteLine("Ngay qua khu");
            }
			else
			{
                Console.WriteLine("Ngay tuong lai");
            }
		}

		//6
		public void configDate(DateTime input)
		{
            Console.WriteLine(input.ToString("dd/MM/yyyy"));
			Console.WriteLine(input.ToString("yyyy/MM/dd"));
            Console.WriteLine(input.ToString("MM/yyyy"));
            Console.WriteLine(input.ToString("MM-yyyy"));
		}

		//7
		public void TenPreviousDate(DateTime input)
		{
			input = input.AddDays(-10);
            Console.WriteLine("10 ngay truoc la thu: {0}",input.DayOfWeek);
        }

		//8
		public void LastDayOfMonth(DateTime input)
		{
			int year = input.Year;
			int month = input.Month;
			if(year % 4 == 0)
			{
				// nam nhuan
				if( month == 2)
				{
					input = input.AddDays(29 - input.Day);
				}
				else if(month<8 && month%2==1)
				{
					input = input.AddDays(31 - input.Day);
				}
				else if (month >= 8 && month%2==0)
				{
					input = input.AddDays(31 - input.Day);
				}
				else
				{
					input = input.AddDays(30 - input.Day);
				}
			}
			else
			{
				// nam khong nhuan
				if (month == 2)
				{
					input = input.AddDays(28 - input.Day);
				}
				else if (month < 8 && month % 2 == 1)
				{
					input = input.AddDays(31 - input.Day);
				}
				else if (month >= 8 && month % 2 == 0)
				{
					input = input.AddDays(31 - input.Day);
				}
				else
				{
					input = input.AddDays(30 - input.Day);
				}
			}
            Console.WriteLine("Ngay cuoi cung cua thang la thu {0}",input.DayOfWeek);
        }

		//10
		public void LastDayOfYear(DateTime input)
		{
			int year = input.Year;
			if (year % 4 == 0)
			{
				// nam nhuan
				input = input.AddDays(366 - input.DayOfYear);
			}
			else
			{
				// nam khong nhuan
				input = input.AddDays(365 - input.DayOfYear);
			}
			Console.WriteLine("Ngay cuoi cung cua nam la thu {0}", input.DayOfWeek);
		}

		//11
		public void KhoangCachGiua2Ngay(DateTime input1, DateTime input2)
		{
			int ngay1 = input1.DayOfYear;
			int ngay2 = input2.DayOfYear;
			int nam1 = input1.Year;
			int nam2 = input2.Year;
			if (nam1 == nam2)
			{
				if (ngay1 > ngay2)
				{
					Console.WriteLine("Khoang cach giua 2 thoi gian la {0} ngay", ngay1 - ngay2);
				}
				else if (ngay2 > ngay1)
				{
					Console.WriteLine("Khoang cach giua 2 thoi gian la {0} ngay", ngay2 - ngay1);
				}
				else
				{
					Console.WriteLine("2 Khoang thoi gian trung nhau");
				}
			}
			else
			{
				if (ngay1 > ngay2)
				{
					Console.WriteLine("Khoang cach giua 2 thoi gian la {0} ngay", Math.Abs((ngay2 - ngay1) * (nam1 - nam2)));
				}
				else
				{
					Console.WriteLine("Khoang cach giua 2 thoi gian la {0} ngay", Math.Abs((ngay2 - ngay1) * (nam1 - nam2)));
				}
			}
		}
	}
}
