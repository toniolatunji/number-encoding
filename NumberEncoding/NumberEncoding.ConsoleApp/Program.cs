using Microsoft.Extensions.DependencyInjection;
using NumberEncoding.Service.Contract;
using System;

namespace NumberEncoding.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ServiceRegistration.GetServiceProvider();

            var numberEncodingService = serviceProvider.GetService<INumberEncodingService>();

            Console.WriteLine("===============Number Encoding===================\n");

            Console.WriteLine("Encode number iteratively. Press Ctrl C on the keyboard to stop and exit\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Enter string to encode: ");

                Console.ForegroundColor = ConsoleColor.White;

                var input = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Output: ");

                Console.ForegroundColor = ConsoleColor.White;

                Console.Write(numberEncodingService.NumberEncoding(input));

                Console.WriteLine("\n");
            }
        }
    }
}
