﻿using System;

namespace lab02_unit_testing
{
    public class Program
    {
        public static decimal balance = 500m;

        /// <summary>
        /// Handles control flow of user interaction and calls helper methods
        /// </summary>
        /// <param name="args">string array</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM game!");
            Console.WriteLine(" ");
            Console.WriteLine("Enter the number of the action you would like to select.");
            Console.WriteLine("   1. View balance\n" +
                "   2. Withdraw funds\n" +
                "   3. Deposit funds\n" +
                "   4. Quit ATM session");

            try
            {
                // Set boolean to true for keeping program running
                bool runATM = true;

                string userAction = Console.ReadLine();

                // Use while loop to continue allowing user actions while boolean set to true
                while (runATM == true)
                {
                    switch (userAction)
                    {
                        case "1":
                            Console.WriteLine("You've selected \"View balance\".");
                            DisplayBalance();
                            break;

                        case "2":
                            Console.WriteLine("You've selected \"Withdraw funds\".");
                            Console.WriteLine("How much money would you like to withdraw?");
                            string amtToWithdraw = Console.ReadLine();
                            decimal amtToWithdrawToDecimal = Convert.ToDecimal(amtToWithdraw);
                            decimal newBalance = WithdrawFunds(amtToWithdrawToDecimal);
                            Console.WriteLine($"Your account balance is {newBalance:C2}");
                            break;

                        case "3":
                            Console.WriteLine("You've selected \"Deposit funds\".");
                            Console.WriteLine("How much money would you like to deposit?");
                            string amtToDeposit = Console.ReadLine();
                            decimal amtToDepositToDecimal = Convert.ToDecimal(amtToDeposit);
                            decimal balanceAfterDeposit = DepositFunds(amtToDepositToDecimal);
                            Console.WriteLine($"Your account balance is {balanceAfterDeposit:C2}");
                            break;

                        case "4":
                            runATM = false;
                            Console.WriteLine("You've selected \"Quit ATM session\".");
                            Console.WriteLine("Hit Enter to exit the program.");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Please enter just a number 1-4.");
                            break;
                    }

                    // Give user option to end ATM session or initiate new session
                    Console.WriteLine(" ");
                    Console.WriteLine("To do a new ATM action, type the number of the action you'd like to do.\n" +
                        "Or hit Enter to exit the program. ");
                    Console.WriteLine("   1. View balance\n" +
                        "   2. Withdraw funds\n" +
                        "   3. Deposit funds\n" +
                        "   4. Quit ATM session");
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
                Console.WriteLine("Hit Enter to exit the program.");
            }
            Console.ReadLine();
        }

        /////////////////////////////
        // Helper methods
        /////////////////////////////

        /// <summary>
        /// Displays account balance to user in console
        /// </summary>
        public static void DisplayBalance()
        {
            Console.WriteLine($"Your account balance is {balance:C2}.");
        }

        /// <summary>
        /// Updates account balance to reflect user deposit
        /// </summary>
        /// <param name="amountToWithdraw">User input specifying amount to withdraw</param>
        /// <returns>Returns an updated account balance as a decimal</returns>
        public static decimal WithdrawFunds(decimal amountToWithdraw)
        {
            decimal newBalance = balance - amountToWithdraw;

            // Incl custom exception "Insufficient funds" upon overdraw
            if (amountToWithdraw > 0)
            {
                if (newBalance > 0)
                {
                    // Attempted update to balance
                    balance = newBalance;
                    Console.WriteLine($"You've successfully withdrawn {amountToWithdraw:C2}.");
                    return newBalance;
                }
                else
                {
                    Console.WriteLine("You have insufficient funds in your account.");
                    return balance;
                }
            }
            else
            {
                Console.WriteLine("You cannot withdraw a negative amount.");
                return balance;
            }
        }

        /// <summary>
        /// Updates account balance to reflect user withdrawal
        /// </summary>
        /// <param name="amountToDeposit"></param>
        /// <returns>Returns an updated account balance as a decimal</returns>
        public static decimal DepositFunds(decimal amountToDeposit)
        {
            if (amountToDeposit > 0)
            {
                decimal accountBalanceAfterDeposit = balance + amountToDeposit;
                balance = accountBalanceAfterDeposit;
                Console.WriteLine($"You've successfully deposited {amountToDeposit:C2}.");
                return accountBalanceAfterDeposit;
            }
            else
            {
                Console.WriteLine("You cannot deposit a negative amount of money.");
                return balance;
            }
        }
    }
}
