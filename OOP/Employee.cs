using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton.OOP
{
	public class Employee
	{
		public string Name { get; set; }
		public int Age { get; set; }
		private static int employeeCount = 0;
		private static DateTime firstEmployeeTime;

		public Employee(string name, int age)
		{
			this.Name = name;
			this.Age = age;
			employeeCount++;
			if (employeeCount == 1)
			{
				firstEmployeeTime = DateTime.Now;
			}
		}

		public virtual void ShowInfo()
		{
            Console.WriteLine($"Toi ten la {this.Name}, {this.Age} tuoi");
        }

		public virtual void ExtInfo()
		{
			var timeDifference = (DateTime.Now - firstEmployeeTime).TotalSeconds;
			Console.WriteLine($"Toi la Nguoi thu {employeeCount}, duoc tao ra sau nguoi dau tien {timeDifference:F2} giay.");
		}

	}
}
