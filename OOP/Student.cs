using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton.OOP
{
	public class Student : Employee
	{
		private static int studentCount = 0;
		private static DateTime firstStudentTime;

		public Student(string name, int age) : base(name, age)
		{
			studentCount++;
			if (studentCount == 1)
			{
				firstStudentTime = DateTime.Now;
			}
		}

		public override void ShowInfo()
		{
			Console.WriteLine($"Toi ten la{this.Name}, {this.Age} tuoi. Toi la sinh vien");
		}

		public override void ExtInfo()
		{
			var timeDifference = (DateTime.Now - firstStudentTime).TotalSeconds;
			Console.WriteLine($"Toi la sinh vien thu {studentCount}, duoc tao ra sau sinh vien dau tien {timeDifference:F2} giay.");
		}
	}
}
