using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TrainingSkeleton.PrimitiveTypes
{
	public class PTString
	{
		//1
		public string CheckStringIsNullOrSpace (string input)
		{
			if(input is null)
			{
                return "Chuoi null";
            }
			if(string.IsNullOrEmpty(input))
			{
                return "Chuoi rong";
            }
			if(input.Trim().Length==0)
			{
                return "Chuoi space";
            }
			return "Chuoi hop le";
		}

		public bool CheckStringIsNullOrSpace1(string input)
		{
			if (input is null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(input))
			{
				return false;
			}
			if (input.Trim().Length == 0)
			{
				return false;
			}
			return true;
		}


		//2
		public string RemoveWhiteFromStartnEnd(string input)
		{
			if(!CheckStringIsNullOrSpace1(input))
			{
				return "Chuoi khong hop le";
			} 
			return input.Trim();
		}

		//3
		public string RemoveAllWhite(string input)
		{
			if (!CheckStringIsNullOrSpace1(input))
			{
				return "Chuoi khong hop le";
			}
			string[] strings = input.Split(' ');
			string ret = "";
			foreach(var item in strings) {
				ret += item;
			}
			return ret;
		}

		//4
		public string UppercaseAfterSpace(string input)
		{
			if (!CheckStringIsNullOrSpace1(input))
			{
				return "Chuoi khong hop le";
			}
			string[] strings = input.Split(' ');
			string ret = "";
			foreach (var item in strings)
			{
				ret += Char.ToUpper(item[0]);
				ret += item.Substring(1);
			}
			return ret;
		}

		//5
		public int CountingSpace(string input)
		{
			if (!CheckStringIsNullOrSpace1(input))
			{
				return -1;
			}
			int count = 0;
			foreach(char item in input)
			{
				if (item == ' ')
				{
					count++;
				} 
			}
			return count;
		}

		//6
		public int CountingCharNotSpace(string input)
		{
			if (!CheckStringIsNullOrSpace1(input))
			{
				return -1;
			}
			int count = 0;
			foreach (char item in input)
			{
				if (item != ' ')
				{
					count++;
				}
			}
			return count;
		}

		//7
		public void CompareString(string input1, string input2)
		{
			if(input1.Equals(input2))
			{
                Console.WriteLine("Chuoi 1 giong chuoi 2");
            }
			else
			{
                Console.WriteLine("Chuoi 1 khac chuoi 2");
            }
		}

		//8 
		public void CompareStringNotUpperLowerCase(string input1, string input2)
		{

			if (input1.ToLower().Equals(input2.ToLower()))
			{
				Console.WriteLine("Chuoi 1 giong chuoi 2");
			}
			else
			{
				Console.WriteLine("Chuoi 1 khac chuoi 2");
			}
		}

		//9 
		public string ReplaceString(string input)
		{
			if (!CheckStringIsNullOrSpace1(input))
			{
				return "Chuoi khong hop le";
			}
			char[] inputArray = input.ToCharArray();
			for (int i = 0; i < inputArray.Length - 2; i++)
			{
			
				if ((inputArray[i] == 'A' || inputArray[i] == 'a') &&
					(inputArray[i + 1] == 'B' || inputArray[i + 1] == 'b') &&
					(inputArray[i + 2] == 'C' || inputArray[i + 2] == 'c'))
				{
					inputArray[i] = (char)(inputArray[i] + 3);       
					inputArray[i + 1] = (char)(inputArray[i + 1] + 3); 
					inputArray[i + 2] = (char)(inputArray[i + 2] + 3);
				}
			}
			return new string(inputArray);
		}

		//10
		public string Greeting(string input)
		{
			if (!CheckStringIsNullOrSpace1(input))
			{
				return "Chuoi khong hop le";
			}
			string orginalInput = "Kinh chao ong ___. Chuc ngon mieng";
			string output = orginalInput.Replace("___", input);
			return output;
		}

		//11
		public string ReverseString(string input)
		{
			if (!CheckStringIsNullOrSpace1(input))
			{
				return "Chuoi khong hop le";
			}
			return new string(input.Reverse().ToArray());
		}

		//12
		public string CutString(string input, int count)
		{
			if (input is null)
			{
				return "Chuoi null";
			}
			if (string.IsNullOrEmpty(input))
			{
				return "Chuoi rong";
			}
			if (input.Trim().Length == 0)
			{
				return "Chuoi space";
			}
			if (count < 0 )
			{
                return "So nho hon 0";
            }
			input = input.TrimStart();
			string output = input.Substring(0, count);
			return output;
		}

		//13
		public string CutString2(string input, int count)
		{
			if (input is null)
			{
				return "Chuoi null";
			}
			if (string.IsNullOrEmpty(input))
			{
				return "Chuoi rong";
			}
			if (input.Trim().Length == 0)
			{
				return "Chuoi space";
			}
			if (count < 0)
			{
				return "So nho hon 0";
			}
			input = input.Trim();
			string output = input.Substring(0, count);
			return output;
		}

		//14
		public string CutString3(string input, int count)
		{
			if (input is null)
			{
				return "Chuoi null";
			}
			if (string.IsNullOrEmpty(input))
			{
				return "Chuoi rong";
			}
			if (input.Trim().Length == 0)
			{
				return "Chuoi space";
			}
			if (count < 0)
			{
				return "So nho hon 0";
			}
			input = input.Trim();
			string output = input.Substring( input.Length-1-count, count);
			return output;
		}
	}
}
