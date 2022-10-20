internal class Program
{

    public static void FillArr(int n, int[] fibanachi)
    {
        //fill array
        for (int i = 2; i < n; i++)
        {
            fibanachi[i] = fibanachi[i - 1] + fibanachi[i - 2];
        }
    }

    public static void ShowArr(int n, int[] fibanachi)
    {
        //show array (part b)
        for (int i = 0; i < n; i++)
        {
            Console.Write(fibanachi[i] + "; ");
        }
        Console.WriteLine();
    }

    public static void ShowKEl(int n,int[] fibanachi)
    {
        //show K array element
        Console.Write($"Enter element number what you need, from 1 till {n} :");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine($"k element ({k}) is {fibanachi[k - 1]}");
        Console.WriteLine();
    }
    public static void SumArr(int[] fibanachi)
    {
        int sumOfArrEl = 0;
        for (int i = 0; i < fibanachi.Length; i++)
        {
            sumOfArrEl = sumOfArrEl + fibanachi[i];
        }
        if (sumOfArrEl % 2 == 0)
            Console.WriteLine($"Sum of array elements is even = {sumOfArrEl}");
        else 
            Console.WriteLine($"Sum of array elements is not even = {sumOfArrEl}");
    }

    private static void Main(string[] args)
    {
        Console.Write("Enter N > 3: ");

        //Create array with N-size
        int n = int.Parse(Console.ReadLine());
        int[] fibanachi = new int[n];
        //We are enter first 2 element
        fibanachi[0] = 1;
        fibanachi[1] = 1;

        FillArr(n, fibanachi);

        ShowArr(n, fibanachi);

        ShowKEl(n, fibanachi);

        SumArr(fibanachi);
    }
}