using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SimpleCSharpApp
{
    class Program
    {
        static void Main()
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            ShowEnvironmentDetails();
            Console.WriteLine();
            //GetUserData();
            FormatNumericalData();
            Console.WriteLine();
            NewingDataTypes();
            Console.WriteLine();
            UseBigInteger();
            Console.WriteLine(); 
            // Wait for Enter key to be pressed before shutting down.
            Console.WriteLine("Press any Key to Exit.!");
            Console.ReadKey();//reads a char
        }

        static void ShowEnvironmentDetails()
        {
            Console.WriteLine("Print out the drives on this machine and other interesting details");
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}",Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}",Environment.Version);
        }

        static void GetUserData()
        {
            // Get name and age.
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();
            // Change echo color, just for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Echo to the console.
            Console.WriteLine("Hello {0}! You are {1} years old.",userName, userAge);
            // Restore previous color.
            Console.ForegroundColor = prevColor;
        }
        static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("Basic Format: {0}",9999);
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            // Notice that upper- or lowercasing for hex
            // determines if letters are upper- or lowercase.
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool(); // Set to false.
            int i = new int(); // Set to 0.
            double d = new double(); // Set to 0.
            DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine(b);
        }

        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger:");
            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            Console.WriteLine("Is biggy a power of two?: {0}",biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy,BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            BigInteger reallyBig2 = biggy + reallyBig;
            Console.WriteLine("Value of reallyBig2 is {0}", reallyBig2);
        }
    }
}
