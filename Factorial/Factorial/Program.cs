using System;

public class FactorialCalculator
{
    /// <summary>
    /// Calculates the factorial of a non-negative integer.
    /// </summary>
    public long CalculateFactorial(int n)
    {
        if (n < 0) throw new ArgumentException("Number must be non-negative.");
        if (n == 0 || n == 1) return 1;

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Factorial Calculator");
        Console.WriteLine("--------------------");
        Console.Write("Enter a number (0-20): ");

        if (int.TryParse(Console.ReadLine(), out int input) && input >= 0)
        {
            var calculator = new FactorialCalculator();
            try
            {
                long result = calculator.CalculateFactorial(input);
                Console.WriteLine($"The factorial of {input} is: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }
    }
}
