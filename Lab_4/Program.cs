class Program
{
    public static void A(in int number)
    {
        Console.WriteLine(string.Format("A (in) = {0}", number));
    }

    public static void B(out int number)
    {
        number = 500;
    }

    public static void C(ref int number)
    {
        number += 100;
    }

    public static int SumValues(params int[] numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("--- in ---");
        int aVal = 42;
        A(in aVal);

		Console.WriteLine("");
        Console.WriteLine("--- out ---");
        int bVal;
        B(out bVal);
        Console.WriteLine(string.Format("After B Call number = {0}", bVal));

		Console.WriteLine("");
        Console.WriteLine("--- ref ---");
        int cVal = 250;
        Console.WriteLine(string.Format("before C call {0}", cVal));
        C(ref cVal);
        Console.WriteLine(string.Format("after C call {0}", cVal));

		Console.WriteLine("");
        Console.WriteLine("--- 'params sum ---");
        Console.WriteLine(string.Format("SumValues(10, 20, 30) = {0}", SumValues(10, 20, 30)));
        Console.WriteLine(string.Format("SumValues(5, 15, 25, 35, 45) = {0}", SumValues(5, 15, 25, 35, 45)));
    }
}