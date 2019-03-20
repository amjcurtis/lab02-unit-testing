using System;

namespace lab02_unit_testing
{
    class Program
    {
        public static decimal balance = 500m;

        /// <summary>
        /// Handles control flow of user interaction and calls helper methods
        /// </summary>
        /// <param name="args">string[]</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM game!");
            Console.WriteLine($"Your balance is {balance:C2}.");

            try
            {
                // Set boolean to true for keeping program running

                // Use while loop to continue allowing user actions while boolean set to true

                // Set boolean to false and end program when user says so

                // 


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The program is finished.");
            }
            Console.ReadLine();
        }

        /////////////////////////////
        // Helper methods
        /////////////////////////////
        
        // Calc balance

        // View balance
            // Display using currency format string

        // WithdrawFunds
            // Update balance
            // Incl custom exception "Insufficient funds" upon overdraw

        // DepositFunds
            // Update balance
            // Handle invalid format exception

    }
}
