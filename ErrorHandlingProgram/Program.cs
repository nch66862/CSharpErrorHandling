using System;
using ExceptionLibrary;

namespace CSharpErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCode demo = new DemoCode();
            int result = demo.GrandparentMethod();
            Console.WriteLine($"The value at the given position is { result }");
            Console.ReadLine();
        }
    }
}
