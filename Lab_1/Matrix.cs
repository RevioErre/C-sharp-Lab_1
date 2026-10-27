namespace Lab_1;

public class Matrix
{
	private readonly int N;
	private int A { set; get; }
	private int B { set; get; }
	private int[][] matrix;
	private void FillMatrix()
	{
		int min = this.A, max = this.B;
		if (this.B < this.A)
		{
			min = this.B;
			max = this.A;
		}
		for (int j = 0; j < this.N; j++)
			for (int i = 0; i < this.N; i++)
				matrix[j][i] = Random.Shared.Next(max - min) + min;
	}

	public Matrix(int N, int A, int B)
	{
		this.N = N;
		this.A = A;
		this.B = B;
		this.matrix = new int[this.N][];
		for (int i = 0; i < N; i++)
			matrix[i] = new int[this.N];

		this.FillMatrix();
	}

	public void ShowMatrix()
	{
		Console.WriteLine("Matrix [{0}][{0}] = [", this.N);
		for (int j = 0; j < this.N; j++)
		{
			Console.Write("\t[{0}", this.matrix[j][0]);
			for (int i = 1; i < this.N; i++)
				Console.Write(", {0}", this.matrix[j][i]);
			Console.WriteLine("]");
		}
		Console.WriteLine("]");
	}

	public int CountOdd()
	{
		int count = 0;
		for (int j = 0; j < this.N; j++)
			for (int i = 0; i < this.N; i++)
				if (this.matrix[j][i] % 2 == 1)
					count++;
		return count;
	}
}