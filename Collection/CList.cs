using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton.Collection
{
	public class CList
	{
		//1
		public List<int> AddRandomNumber()
		{
			Random random = new Random();
			List<int> lst = new List<int>();
			for(int i = 0;i<10;i++)
			{
				lst.Add(random.Next(int.MinValue, int.MaxValue));
			}
			return lst;
		}

		//2
		public List<int> SortList(List<int> input)
		{
			if(input.Count > 10)
			{
				throw new ArgumentException("Chi duoc nhap danh sach 10 so");
            }
			input.Sort((a,b) => a.CompareTo(b));
			return input;
		}

		//3
		public List<int> ReverseList(List<int> input)
		{

			if (input.Count > 10)
			{
				throw new ArgumentException("Chi duoc nhap danh sach 10 so");
			}
			input.Reverse();
			return input;
		}

		//4
		public List<int> RemoveLessThanX(List<int> input,int x)
		{

			if (input.Count > 10)
			{
				throw new ArgumentException("Chi duoc nhap danh sach 10 so");
			}
			input.RemoveAll(number=>number < x);
			return input;
		}

		//5
		public List<int> RemoveDivisiblenX(List<int> input, int x)
		{

			if (input.Count > 10)
			{
				throw new ArgumentException("Chi duoc nhap danh sach 10 so");
			}
			input.RemoveAll(number => number % x == 0);
			return input;
		}

		//6
		public List<int> PlusIfLessThanX(List<int> input, int x)
		{

			if (input.Count > 10)
			{
				throw new ArgumentException("Chi duoc nhap danh sach 10 so");
			}
			for(int i = 0; i<input.Count;i++)
			{
				if (input[i]<x)
				{
					input[i] += x;
				}
			}
			return input;
		}

		//7 
		public List<int> PrintFromList(List<int> input,int x)
		{
			if(x<0)
			{
				throw new ArgumentException("X phai lon hon 0");
			}
			if(x>10)
			{
				throw new ArgumentException("X phai nho hon 10");
			}
			input.RemoveRange(0, input.Count - x);
			return input;
		}

		//8
		public List<int> PrintFromListReverse(List<int> input, int x)
		{
			if (x < 0)
			{
				throw new ArgumentException("X phai lon hon 0");
			}
			if (x > 10)
			{
				throw new ArgumentException("X phai nho hon 10");
			}
			input.RemoveRange(0, input.Count - x);
			input.Reverse();
			return input;
		}

		//9
		public List<int> GenerateFibonacci(int x)
		{
			List<int> fibonacciList = new List<int>();
			int b = 1;
			fibonacciList.Add(x);
			fibonacciList.Add(x + 1);
			for (int i = 0; i < 8; i++)
			{
				int next = x + b;
				fibonacciList.Add(x + next);
				b = x;
				x = next;
			}
			return fibonacciList;
		}


	}
}
