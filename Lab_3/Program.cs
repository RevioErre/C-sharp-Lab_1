namespace Lab_3;

class Program
{
	static void Main()
	{
		Console.Write("Enter film count: ");
		if (int.TryParse(Console.ReadLine(), out int count))
		{
			Movie[] movies = new Movie[count];

			Console.WriteLine("\nEnter info in following order:");
			Console.WriteLine("Name  Year  Genre(1-5)  Views  Likes");
			Console.WriteLine("Example: Inception 2010 4 150000 12000\n");

			for (int i = 0; i < count; i++)
			{
				Console.Write($"Movie #{i + 1}: ");
				string input = Console.ReadLine();
				string[] parts = input.Split(" ");

				if (parts.Length >= 5)
				{
					try
					{
						Genre genre = (Genre)int.Parse(parts[2]);
						movies[i] = new Movie(i + 1, parts[0], int.Parse(parts[1]), genre,
						int.Parse(parts[3]), int.Parse(parts[4]));
					}
					catch (Exception)
					{
						Console.WriteLine("Parsing error. please retry.");
						i--;
					}
				}
				else
				{
					Console.WriteLine("Try again. Line length is less than 5 elements");
					i--;
				}
			}

			Console.WriteLine();
			Console.WriteLine("Printing Film data");
			for (int i = 0; i < count; i++)
				Console.WriteLine(movies[i]);
		}
		else
		{
			Console.WriteLine("Count parse error. Restart the program.");
		}
	}
}