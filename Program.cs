namespace Lab_1;
public class Program
{
	public static void Main()
	{
		int N = 6, A = -100, B = 1000;
		Console.WriteLine("Creating Matrix[{0}][{0}] with values from {1} -> {2}", N, A, B);
		Matrix mat = new Matrix(N, A, B);
		Console.WriteLine("Printing matrix ...");
		mat.ShowMatrix();
		Console.WriteLine("Count of odd elemets:{0}", mat.CountOdd());
	}
}