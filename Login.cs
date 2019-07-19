using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework//maybe try with do while for true or false boolean
{
    class Login
    {
        static void Main()
        {
            Console.WriteLine("Creating a login for username and password");
            Console.Title = "User Login";

            /*--create variables for username and password--could maybe use constants
             * --write and readlines for both username and password
             * --3 attempts for username and three attempts for password
             * if branch and loop or two needed
             * */
            const string username = "AlWilliams0219";
            const string password = "PyThOn&C#cOdE2019";
            byte attempts = 2;
            

            Console.Write("Enter your user name: ");
            string userInput = Console.ReadLine();
            #region
            if (userInput == username)
            {
                Console.Write("Enter your password: ");
                string userPass = Console.ReadLine();
                if (userPass == password)
                {
                    Console.WriteLine("Welcome to your account!");
                }//end if
                else
                {
                    for (int i = 0; i <= attempts; i++)
                    {
                            Console.Write($"The password is incorrect. {attempts--} attempts remaining.\n" +
                              "Please enter your password again: ");
                            userPass = Console.ReadLine();
                            Console.Clear();
                        if (userPass == password)
                        {
                            Console.WriteLine("Welcome to your account!");
                            
                        }//end if
                        else if (attempts == 0) 
                        {
                            Console.WriteLine("You have no attempts left. You have now been locked out of your account." +
                               " \nContact customer service for further assistance.");
                           
                         }//end else
                    }//end for
                }//end else
            }//end if
            #endregion
            #region
            else if (userInput != username)
            {
                Console.Write($"Username is incorrect. You have {attempts--} remaining.\n" +
                    "Please re-enter the username: ");
                userInput = Console.ReadLine();
                if (userInput == username)//need to add the password code
                {
                    Console.WriteLine("Welcome to your account!");
                }//end if
                else
                {
                    for (int x = 0; x <= attempts; x++)
                    {
                        Console.Write($"Your user name is incorrect. You have {attempts--} remaining.\nPlease re-enter your username: ");
                        userInput = Console.ReadLine();
                        if (x == 2)
                        {
                            Console.WriteLine("You have no attempts remaining and have been locked out of your account.\n" +
                                "Contact customer service for support.");
                        }//end if
                        else if (userInput == username)// need something for if 2nd or 3rd attempt correct
                        {
                            Console.Write("Please enter your password: ");
                            string userPass = Console.ReadLine();
                            if (userPass == password)
                            {
                                Console.WriteLine("Welcome to your account!");
                            }//end if
                            else if (userPass != password)
                            {
                                for (int z = 0; z < attempts; z++)//need to add another spot to enter the password 
                                {
                                    Console.Write("The password was incorrect. Enter password: ");
                                    userPass = Console.ReadLine();
                                    if (attempts == 0)
                                    {
                                        Console.WriteLine("You have been locked out of your account. Contact customer support.");
                                    }
                                }//end for
                            }//end else if
                        }//end else if
                    }//end for
                }//end else
            }//end else
                    
            #endregion
        }//end Main()
    }//end class
}//end namespace
