using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton.PrimitiveTypes
{
	public class PTInt
	{
		//1
		public void OddEvenNumber(int input)
		{
			if(input <= 0)
			{
                Console.WriteLine("So <= 0");
				return;
            }
			if( input % 2 == 0)
			{
                Console.WriteLine("So chan");
				return;
            }
            Console.WriteLine("So le");
			return;
        }

		//2
		public void ABS(int input)
		{
            Console.WriteLine(Math.Abs(input));
		}

		//3
		public void Mu(int input)
		{
			if (input <= 0)
			{
				Console.WriteLine("So <= 0");
				return;
			}
            Console.WriteLine(Math.Pow(2,input));
        }

		//4 
		public void ChiaCoDu(double x, double y)
		{
            Console.WriteLine($"{x} / {y} = {x/y} du {x%y}");
        }

		//5
		public void isPrime(int input)
		{
			if(input <= 0 )
			{
                Console.WriteLine("So <= 0");
				return;
            }

			if(input <=1 )
			{
                Console.WriteLine("So nguyen to phai lon hon 1");
				return;
            }

			for(int i = 2; i<=Math.Sqrt(input); i++)
			{
				if(input %i ==0)
				{
                    Console.WriteLine("Day khong phai so nguyen to");
					return;
                }
                Console.WriteLine("Day la so nguyen to");
				return;
            }
		}

		//6 
		public void KiemTraChuoiSo (string input)
		{
			if(Int32.TryParse(input,out _))
			{
                Console.WriteLine("Day la chuoi so");
				return;
            }
            Console.WriteLine("Day khong phai chuoi so");
			return;
        }

	}
}
