partial class LetterPrinter
{
	static void Main()
	{

		Dictionary<char, char[,]> dict = new() {
            {'_', letterUnderscore},
            {' ', letterBlank},
			{'A', letterA},
			{'B', letterB},
			{'C', letterC},
			{'D', letterD},
			{'E', letterE},
			{'F', letterF},
			{'G', letterG},
			{'H', letterH},
			{'I', letterI},
			{'J', letterJ},
			{'K', letterK},
			{'L', letterL},
			{'M', letterM},
			{'N', letterN},
			{'O', letterO},
			{'P', letterP},
			{'Q', letterQ},
			{'R', letterR},
			{'S', letterS},
			{'T', letterT},
			{'U', letterU},
			{'V', letterV},
			{'W', letterW},
			{'X', letterX},
			{'Y', letterY},
			{'Z', letterZ},
			{'0', number0},
			{'1', number1},
			{'2', number2},
			{'3', number3},
			{'4', number4},
			{'5', number5},
			{'6', number6},
			{'7', number7},
			{'8', number8},
			{'9', number9},
		};

		while (true)
		{
			bool valid = true;

			Console.WriteLine("-----LetterPrinter 0.2 | Made by HolyPeach-----\n");
			Console.WriteLine("!!!--Input can be Alphanumeric, spaces, and underscores-----");
			Console.WriteLine("!!!--If the characters don't appear correctly resize the console or enter a shorter string-----\n");
			Console.Write("Enter the string to convert: ");
			string input = Console.ReadLine() ?? "";
			input = input.Trim();
			input = input.ToUpper();
			char[][,] matrix = new char[input.Length][,];
			if (matrix.GetLength(0) != 0)
			{
				for (int index = 0; index < input.Length; index++)
				{
					try
					{
						matrix[index] = dict[input[index]];
					}
					catch
					{
						valid = false;
						Console.WriteLine("\n!!!--One or more of the characters entered are not valid-----\n");
					}
					if (!valid)
					{
						break;
					}
				}
				if (valid)
				{
					PrintLetters(matrix);
				}
			}
			else
			{
				Console.WriteLine("\n!!!--Please enter something...\n");
			}

			Console.Write("Press any key to continue...");
			Console.ReadKey();
			Console.Clear();
		}
	}

	static void PrintLetters(char[][,] matrix)
	{
		Console.WriteLine("\n\n");
		for (int row = 0; row < matrix[0].GetLength(0); row++)
		{
			for (int array = 0; array < matrix.Length; array++)
			{
				for (int letter = 0; letter < matrix[0].GetLength(1); letter++)
				{
					Console.Write(matrix[array][row, letter]);
				}
				Console.Write("  ");
			}
			Console.Write("\n");
		}
		Console.WriteLine("\n\n");
	}
}
