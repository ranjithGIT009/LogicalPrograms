using static System.Runtime.InteropServices.JavaScript.JSType;

class FibonnaciSeries
{
    public static void Main(string[] args) // Fix array type specifier and ambiguity
    {
        Console.WriteLine("Enter the number to generate the Fibonaci series:");
        Console.WriteLine("-------------------------------------------------");
        int n = 0;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 0) // Fix variable declaration
        {
            Console.WriteLine("Please enter a valid non-negative integer.");
            return;
        }
        //int IstElmt = 0;
        //int IIndElmt = 1;
        int[] arr = new int[n];
        //arr[0] = IstElmt;
        //arr[1]= IIndElmt;
        for (int i = 0; i < n; i++)
        {
            arr[i] = (i <= 1) ? i : arr[i - 1] + arr[i - 2]; // Fix Fibonacci calculation and handle first two elements
          //  arr[i] = arr[i - 1] + arr[i - 2];   
        }
        Console.WriteLine("The Fibonacci series are:");
        Console.WriteLine("-------------------------");

        Console.WriteLine(string.Join(", ", arr));
    }
}
