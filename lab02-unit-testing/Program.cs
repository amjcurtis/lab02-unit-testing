using System;

namespace lab02_unit_testing
{
    public class Program
    {
        public static decimal balance = 500m;

        /// <summary>
        /// Handles control flow of user interaction and calls helper methods
        /// </summary>
        /// <param name="args">string[]</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM game!");
            Console.WriteLine(" ");
            Console.WriteLine("Enter the number of the action you would like to select.");

            try
            {
                // Set boolean to true for keeping program running
                bool runATM = true;

                // Use while loop to continue allowing user actions while boolean set to true
                while (runATM == true)
                {
                    Console.WriteLine("   1. View balance\n" +
                        "   2. Withdraw funds\n" +
                        "   3. Deposit funds\n" +
                        "   4. Quit ATM session");

                    string userAction = Console.ReadLine();

                    switch (userAction)
                    {
                        case "1":
                            Console.WriteLine("You've selected \"View balance\".");
                            DisplayBalance();
                            break;

                        case "2":
                            Console.WriteLine("You've selected \"Withdraw funds\".");
                            // Call WithdrawFunds

                            break;

                        case "3":
                            Console.WriteLine("You've selected \"Deposit funds\".");
                            // Call DepositFunds

                            break;

                        case "4":
                            runATM = false;
                            Console.WriteLine("You've selected \"Quit ATM session\".");
                            break;

                        default:
                            Console.WriteLine("Please enter just a number 1-4.");
                            break;
                    }

                    // Give user option to end ATM session or initiate new session
                    Console.WriteLine(" ");
                    Console.WriteLine("To start a new ATM session, type the number of the action you'd like to do.\nOr hit Enter to exit the program. ");
                    userAction = Console.ReadLine();
                    if (userAction != "1" &&
                        userAction != "2" &&
                        userAction != "3" &&
                        userAction != "4")
                    {
                        runATM = false;
                    }
                }
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

        // Calc/update balance

        // DisplayBalance
        static void DisplayBalance()
        {
        
            // Display using currency format string
            Console.WriteLine($"Your balance is {balance:C2}.");

        }

        // WithdrawFunds
            // Update balance
            // Incl custom exception "Insufficient funds" upon overdraw

        // DepositFunds
            // Update balance
            // Handle invalid format exception

    }
}
