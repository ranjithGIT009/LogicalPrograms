
public class ArmstrongNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Find the Given number is Armstrong Number or not");
        Console.WriteLine("\n-------------------------------------------------");
        Console.WriteLine("Enter the Number:");
        // 1. Use TryParse to prevent crashes on non-numeric input
        if (!int.TryParse(Console.ReadLine(), out int num) || num < 0)
        {
            Console.WriteLine("Please enter a valid non-negative integer.");
            return;
        }      
        int sum = 0;
        int temp = num;
        if(num < 0)
        {
            Console.WriteLine("Negative numbers cannot be Armstrong numbers.");
            return;
        }
        for (int i = 0; temp >= 1; i++)
        {
            int rem = temp % 10;
            sum+= rem * rem * rem;
            temp/= 10;            
        }
        if (sum == num)
        {
            Console.WriteLine($"{num} is an Armstrong Number.");
        }
        else
        {
            Console.WriteLine($"{num} is not an Armstrong Number.");
        }
    }
}