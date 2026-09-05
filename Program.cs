using HumanizerMethods;
using FibonacciMethod;
using System.Diagnostics;

class SampleClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantities:");
        HClass.HumanizeQuantities();

        Console.WriteLine("\nDate/Time Manipulation:");
        HClass.HumanizeDates();

        Console.WriteLine("\n\n");

        var fib = FClass.Fibonacci(10);
        Console.WriteLine(string.Join(", ", fib));
        
        Console.WriteLine("\n\n");

        Trace.WriteLine("This is a trace message when tracing the app.");
        Debug.WriteLine("This is a debug message just for developers.");
        
        Console.WriteLine("\n\n");
    }


}

