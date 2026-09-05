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

        Console.WriteLine("\n");

        var fib = FClass.Fibonacci(10);
        Console.WriteLine(string.Join(", ", fib));

        Trace.WriteLine("This is a trace message when tracing the app.");
        Debug.WriteLine("This is a debug message just for developers.");
    }


}

