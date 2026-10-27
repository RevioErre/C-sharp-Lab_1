public class Program
{
	public static int ToMultiplicate(int x, int N = 2)
	{
		int sum = 0;
		for (int i = 0; i < N; i++)
			sum += x;
		return sum;
	}

	public static double ToMultiplicate(double x, int N = 2)
	{
		double sum = 0;
		for (int i = 0; i < N; i++)
			sum += x;
		return sum;
	}

	public static string ToMultiplicate(string x, int N = 2)
	{
		string result = "";
		for (int i = 0; i < N; i++)
			result += x;
		return result;
	}

	static void Main()
	{
		Console.WriteLine("--- Int ---");
		Console.WriteLine(ToMultiplicate(5));
		Console.WriteLine(ToMultiplicate(5, 3));
		Console.WriteLine("");
		Console.WriteLine("--- Double ---");
		Console.WriteLine(ToMultiplicate(4.5));
		Console.WriteLine(ToMultiplicate(2.5, 4));
		Console.WriteLine("");
		Console.WriteLine("--- String ---");
		Console.WriteLine(ToMultiplicate("AABB"));
		Console.WriteLine(ToMultiplicate("CA", 3));
	}
}