using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TrainingSkeleton.Collection;
using TrainingSkeleton.File_;
using TrainingSkeleton.LapVaReNhanh;
using TrainingSkeleton.OOP;


namespace TrainingSkeleton
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime inputDatetime = DateTime.ParseExact("11/12/2024", "MM/dd/yyyy", CultureInfo.InvariantCulture);

			WorkWithFile file = new WorkWithFile();
			file.ReadnWriteFile("input.txt","output.txt");
		}
	}
}
