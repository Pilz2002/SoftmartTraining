using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton.PrimitiveTypes
{
	public class PTDecimal
	{
		public void ChiaThapPhan(double x, double y, int z)
		{
            Console.WriteLine(((double)x/y).ToString($"F{z}"));
		}
	}
}
