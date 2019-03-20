using System;

namespace lab02_unit_testing
{
    class Program
    {
        public static decimal balance = 500m;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM game!");
            Console.WriteLine($"Your balance is {balance:C2}.");



            Console.ReadLine();
        }
    }
}
