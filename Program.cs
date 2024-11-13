using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingSkeleton.Collection;

namespace TrainingSkeleton
{
	internal class Program
	{
		static void Main(string[] args)
		{
			

			DateTime inputDatetime1 = DateTime.ParseExact("11/12/2020", "MM/dd/yyyy", CultureInfo.InvariantCulture);
			DateTime inputDatetime2 = DateTime.ParseExact("12/23/2024", "MM/dd/yyyy", CultureInfo.InvariantCulture);
			CList cList = new CList();
			List<int> lst = cList.GenerateFibonacci(5);
			foreach(var item in lst)
			{
                Console.WriteLine(item);
            }
		}
	}
}
