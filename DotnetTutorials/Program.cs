using System;

namespace DotnetTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "Pythagoras";

            Console.WriteLine($"Hello World! - {response}");

            //Operating system
            OperatingSystem thisOs = Environment.OSVersion;

            Console.WriteLine($"Operating System Platform - {thisOs.Platform}");
            Console.WriteLine($"Operating System Version - {thisOs.Version}");
        }
    }
}
