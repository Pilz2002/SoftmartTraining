using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton.OOP
{
	public class Teacher : Employee
	{
		private static int teacherCount = 0;
		private static DateTime firstTeacherTime;
		public Teacher(string name, int age) : base(name, age)
		{
			teacherCount++;
			if(teacherCount == 1)
			{
				firstTeacherTime = DateTime.Now;
			}
		}

		public override void ShowInfo()
		{
			Console.WriteLine($"Toi ten la Giao Vien, {this.Age} tuoi, toi ten la {this.Name}");
		}

		public override void ExtInfo()
		{
			var timeDifference = (DateTime.Now - firstTeacherTime).TotalSeconds;
			Console.WriteLine($"Toi la giao vien thu {teacherCount}, duoc tao ra sau giao vien dau tien {timeDifference:F2} giay.");
		}
	}
}
