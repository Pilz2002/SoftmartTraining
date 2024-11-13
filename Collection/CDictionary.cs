using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton.Collection
{
	public class CDictionary
	{
		//1
		public IDictionary<int,string> DictionaryStudent()
		{
			Dictionary<int, string> studentDic = new Dictionary<int, string>();
			studentDic.Add(1, "Nguyen Van A");
			studentDic.Add(2, "Nguyen Van B");
			studentDic.Add(3, "Nguyen Van C");
			studentDic.Add(4, "Nguyen Van D");
			studentDic.Add(5, "Nguyen Van E");
			foreach(KeyValuePair<int,string> kvp in studentDic)
			{
				Console.WriteLine("Key: {0}, Value: {1}",kvp.Key,kvp.Value);
            }
			return studentDic;
		}

		//2
		public void FindStudent(KeyValuePair<int,int> input)
		{
			IDictionary<int, string> studentDic = DictionaryStudent();
			foreach (KeyValuePair<int, string> kvp in studentDic)
			{
				if(kvp.Key == input.Value)
				{
                    Console.WriteLine("Ten sinh vien:{0}",kvp.Value);
                }
				else
				{
                    Console.WriteLine("Khong co SV ma {0}", input.Key);
                }
			}
		}

		//3
		public void AddStudent(KeyValuePair<int, string> input)
		{
			IDictionary<int, string> studentDic = DictionaryStudent();
			foreach (KeyValuePair<int, string> kvp in studentDic)
			{
				if (kvp.Key == input.Key)
				{
					Console.WriteLine("Da co ma sinh vien {0} trong dictionary", input.Value);
				}
				else
				{
					studentDic.Add(input);
					Console.WriteLine("Da them sinh vien:{0} - {1}", input.Key, input.Value);
				}
			}
		}

		//4
		public void ReplaceStudent(KeyValuePair<int, string> input)
		{
			IDictionary<int, string> studentDic = DictionaryStudent();
			foreach (KeyValuePair<int, string> kvp in studentDic)
			{
				if (kvp.Key == input.Key)
				{
					Console.WriteLine("Sinh vien co ma {0} trong dictionary doi ten tu {1} thanh {2}", input.Key,kvp.Value,input.Value);
					studentDic[input.Key] = input.Value;
				}
				else
				{
					Console.WriteLine("Da them sinh vien:{0} - {1}", input.Key, input.Value);
					studentDic.Add(input);
				}
			}
		}

		//5
		public void RemoveStudent(KeyValuePair<int, string> input)
		{
			IDictionary<int, string> studentDic = DictionaryStudent();
			foreach (KeyValuePair<int, string> kvp in studentDic)
			{
				if (kvp.Key == input.Key)
				{
					Console.WriteLine("Sinh vien co ma {0} trong dictionary da bi xoa", input.Key);
					studentDic.Remove(input.Key);
				}
				else
				{
					Console.WriteLine("Khong sinh vien co ma: {0}", input.Value);
				}
			}
		}

	}
}
