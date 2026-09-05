using HumanizerMethods;
using FibonacciMethod;

class SampleClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantities:");
        HClass.HumanizeQuantities();

        Console.WriteLine("\nDate/Time Manipulation:");
        HClass.HumanizeDates();

        Console.WriteLine("\n");

        var fib = FClass.Fibonacci(10);
        Console.WriteLine(string.Join(", ", fib));
    }


}

