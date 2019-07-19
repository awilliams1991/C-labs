using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM machine");
            Console.Title = "ATM";

            Console.Clear();
            bool repeat = true;
            decimal balance = 0;
            const string accountNumber = "9876543210";
            const string pinNumber = "1234";


            Console.Write("Welcome to ABC bank ATM. Please enter your account number: ");
            string userAccount = Console.ReadLine();

            while (userAccount != accountNumber)
            {
                Console.Write("Incorrect account number. Please try again: ");
                userAccount = Console.ReadLine();
            }//end while for username had to isolate the while loop so it wouldn't try to execute every time

            if (userAccount == accountNumber)
                {
                    Console.Write("Please enter your pin number: ");
                    string userPin = Console.ReadLine();

                    while (userPin != pinNumber)
                    {
                        Console.WriteLine("Incorrect pin number please try again.");
                        userPin = Console.ReadLine();

                    }//end while for pin number


                if (userPin == pinNumber)
                    {
                        do
                        {
                        Console.Title = balance.ToString("c");//can also be written String.Format(); allows us to write a string
                                                              //String.Format("Balance: {0:c}");

                        Console.Write("B) Balance W) Withdrawl D) Deposit X) End Transaction \n");
                        ConsoleKey userChoice = Console.ReadKey(true).Key;

                        Console.Clear();

                        switch (userChoice)
                            {
                            case ConsoleKey.B://why doesn't consolekey not like numeric values
                                Console.WriteLine($"Your balance is {balance:c}");
                                break;

                            case ConsoleKey.W:
                                Console.Write("How much would you like to withdrawl? ");
                                decimal userInput = Convert.ToDecimal(Console.ReadLine());

                                if (userInput <= balance)
                                    {
                                    Console.WriteLine($"You withdrew {userInput:c}.");
                                    balance -= userInput;//need to have this statement in the if or it will always do it even if exceeds 
                                                         //balance
                                    }//end if
                                else
                                    {
                                    Console.WriteLine("Insufficent funds");//title bar still subtracts amount and converts it to positive

                                    }//end else
                                break;

                            case ConsoleKey.D:
                                Console.Write("How much would you like to deposit? ");
                                decimal userDeposit = Convert.ToDecimal(Console.ReadLine());
                                balance += userDeposit;
                                Console.WriteLine($"You deposited {userDeposit:c}.");
                                break;

                            case ConsoleKey.X:
                                Console.WriteLine("Thank you for visiting the ABC ATM. Your final balance is {0:c}", balance);
                                Console.Title = balance.ToString("c");
                                repeat = false;
                                break;

                            default:
                                Console.WriteLine("Invalid option");
                                break;
                            }//end switch
                        } while (repeat);//end do while
                    }//end if for password
                   
                }//end if for username


            

            

        }//end Main()
    }//end class
}//end namespace
