using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton.File_
{
	public class WorkWithFile
	{
		public void ReadnWriteFile(string inFile, string outFile)
		{
			string[] lines = File.ReadAllLines(inFile);
			List<string> outputLines = new List<string>();

			foreach (string line in lines)
			{
				string[] items = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
				List<int> validNumbers = new List<int>();
				bool isFormatError = false;
				List<string> errors = new List<string>();

				List<string> outPutLines = new List<string>();
				foreach (string item in items)
				{
					try
					{
						int number = Convert.ToInt32(item);
						validNumbers.Add(number);
					}
					catch (FormatException)
					{
						isFormatError = true;
						errors.Add(item);
					}
					catch (OverflowException)
					{
						validNumbers.Add(-1);
					}
				}

				if (isFormatError)
				{
					outputLines.Add($"Format không đúng: {string.Join(" ", errors)}");
				}
				else
				{
					validNumbers.Sort();
					outputLines.Add(string.Join(" ", validNumbers));
				}
			}
			File.WriteAllLines(outFile, outputLines);
		}
	}
}
