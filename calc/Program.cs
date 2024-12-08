using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Write("Enter your command type: ");
		string command = Console.ReadLine();
		switch (command)
		{
			case "shapewriter":
				Console.Write("Enter your shape: ");
				string shape = Console.ReadLine();
				Console.Write("Enter width: ");
				int width = int.Parse(Console.ReadLine());
				Console.Write("Enter height: ");
				int height = int.Parse(Console.ReadLine());
				switch (shape)
				{
					case "square":
						for (int i = 0; i < width; i++)
						{
							for (int j = 0; j < height; j++)
							{
								Console.Write("*");
							}
							Console.WriteLine();
						}
						break;

					case "triangle":
						for (int i = 0; i < width; i++)
						{
							for (int j = 0; j < height; j++)
							{
								Console.Write("*");
							}
							Console.WriteLine();
						}
						break;
				}
				break;

			case "Calc":
				Console.Write("Enter 1 number: ");
				int firstNumber = int.Parse(Console.ReadLine());
				Console.Write("Enter 2 number: ");
				int secondNumber = int.Parse(Console.ReadLine());
				Console.Write("Enter symbol: ");
				string symbol = Console.ReadLine();
				switch (symbol)
				{
					case "+":
						Console.WriteLine($"Sum: {firstNumber + secondNumber}");
						break;
					case "-":
						Console.WriteLine($"Minus {firstNumber - secondNumber}");
						break;
					case "*":
						Console.WriteLine($"Multiply {firstNumber * secondNumber}");
						break;
					case "/":
						   Console.WriteLine($"Division {firstNumber / secondNumber}");
						   break;
				}
				break;
		}
	}
}
