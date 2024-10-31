using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
	internal class NumberToWords
	{
		private static readonly Dictionary<int, string> Units = new Dictionary<int, string>
		{
			{0, ""},
			{1, "One"},
			{2, "Two"},
			{3, "Three"},
			{4, "Fours"},
			{5, "Five"},
			{6, "Six"},
			{7, "Seven"},
			{8, "Eight"},
			{9, "Nine"},


		};
		private static readonly Dictionary<int, string> Teens = new Dictionary<int, string>
		{
			{10, "Ten"},
			{11, "Eleven"},
			{12, "Twelve"},
			{13, "Thirteen"},
			{14, "Fourteen"},
			{15, "Fifteen"},
			{16, "Sixteen"},
			{17, "Seventeen"},
			{18, "Eighteen"},
			{19, "Nineteen"},


		};

		private static readonly Dictionary<int, string> Tens = new Dictionary<int, string>
		{
			{20, "Twenty"},
			{30, "Thirty"},
			{40, "Forty"},
			{50, "Fifty"},
			{60, "Sixty"},
			{70, "Seventy"},
			{80, "Eighty"},
			{90, "Ninety"},
		};
		public string ToWords(int number)
		{
			if (number < 0 || number > 9999)
			{
				throw new ArgumentOutOfRangeException("Number must be between 0 and 9999.");
			}

			if (number == 0)
			{
				return "Zero"; // Handle the case for 0 if needed
			}

			string words = "";

			// Handle thousands
			if (number >= 1000)
			{
				words += Units[number / 1000] + " Thousand ";
				number %= 1000;
			}

			// Handle hundreds
			if (number >= 100)
			{
				words += Units[number / 100] + " Hundred ";
				number %= 100;
			}

			// Handle tens and units with dash condition
			if (number >= 20)
			{
				words += Tens[number - number % 10]; // Add tens part (e.g., "Twenty", "Thirty")
				number %= 10;

				// Add dash if the last digit is not zero
				if (number > 0)
				{
					words += "-" + Units[number]; 
				}
			}
			else if (number >= 10)
			{
				words += Teens[number] + " ";
				return words.Trim(); // Return early for teen numbers
			}
			else if (number > 0) // Handle units if less than 10
			{
				words += Units[number] + " ";
			}

			return words.Trim(); // Trim to remove any trailing spaces
		}


	}
}
