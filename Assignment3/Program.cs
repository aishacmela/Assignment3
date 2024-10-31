namespace Assignment3
{
	internal class Program
	{


		static void Main(string[] args)
		{
			// Create an instance of the NumberToWords class
			var converter = new NumberToWords();

			while (true)
			{
				Console.WriteLine("Enter a number between 0 and 9999 (or type 'exit' to quit):");

				// Read user input
				string input = Console.ReadLine();

				// Check for exit command
				if (input.ToLower() == "exit")
				{
					break; // Exit the loop if user types "exit"
				}

				// Attempt to parse the input as an integer
				if (int.TryParse(input, out int number))
				{
					if (number >= 0 && number <= 9999)
					{
						// Convert the number to words
						string words = converter.ToWords(number);
						Console.WriteLine($"{number} -> {words}");
					}
					else
					{
						Console.WriteLine("Please enter a number between 0 and 9999.");
					}
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a valid integer.");
				}
			}
		}
	}
}
