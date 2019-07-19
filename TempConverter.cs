using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main()
        {
            Console.WriteLine("Creating a temperature conversion program");
            Console.Title = "Convert me!";
            /*
             * a. First, write a program that asks the user for a temperature in Celsius and
                converts it to Fahrenheit. The conversion is done by multiplying the Celsius temp
            by 9/5 and then adding 32. (fah = cel * (9.0/5.0) +32). When testing your
            program, use 100 degrees Celsius as an example – the result should be 212
            degrees Fahrenheit.
            b. Next write additional functionality that asks the user for a Fahrenheit
            temperature and converts it to Celsius. The conversion is done by taking the
            Fahrenheit temperature, subtracting 32, then dividing by 9/5.(cel = (fah – 32) /
            (9.0/5.0)
            c. Next, build out a menu that allows the user to choose whether they wish to
            convert Celsius to Fahrenheit or Fahrenheit to Celsius. Remember, you’ll want to
            capture the user’s input, and then utilize the two pieces of functionality you built
            (steps a, b) to show the result.
            d. Finally, extend the functionality to ask the user if they have another conversion
            once you have shown them their initial result.Reload the menu if they choose
            yes.
            Example Reference:
            InputLab.cs class in _4Thursday – receiving input
            LoopingDoWhile.cs class in _5Friday– repeat code based on user decision
             */

            /*
             * capture a double variable for celcius temp
             * write a loop to run the variable through to convert. --maybe an if/else statment or need to seperate into two different
             * loops
             * can use branching switch logic to build a menu--one for celcius to f and the other from f to c
             * */

            bool repeat = true;
            do
            {
                Console.Write("Are you converting to A) Farenheit or B) Celcius: X) Exit");
                string userChoice = Console.ReadLine().ToLower();
                char temp = '\u00b0';//added this to display the desired temp symbol

                switch (userChoice)
                {
                    case "a":
                    case "farenheit":
                        Console.Write("Provide a temperature in degrees Celcius: ");
                        double tempCelcius = Convert.ToDouble(Console.ReadLine());
                        double tempFarenheit = (tempCelcius * (9.0 / 5.0) + 32);
                        Console.WriteLine($"{tempFarenheit}{temp}");
                        break;

                    case "b":
                    case "celcius":
                        Console.Write("Provide a temperature in degrees Farenheit: ");
                        double farenheitTemp = Convert.ToDouble(Console.ReadLine());
                        double celciusTemp = (farenheitTemp - 32) / (9.0 / 5.0);
                        Console.WriteLine($"{celciusTemp}{temp}");
                        break;

                    case "x":
                    case "exit":
                        Console.WriteLine("Thank you!");
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("That is not a valid option. Please choose again");
                        break;

                }//end switch
            } while (repeat);

            #region
            //Console.Write("Provide a temperature in degrees Celcius: ");
            //double tempCelcius = Convert.ToDouble(Console.ReadLine());
            //double tempFarenheit = (tempCelcius * (9.0 / 5.0) + 32);
            //Console.WriteLine(tempFarenheit);

            //Console.Write("Provide a temperature in degrees Farenheit: ");
            //double farenheitTemp = Convert.ToDouble(Console.ReadLine());
            //double celcuisTemp = (farenheitTemp - 32) / (9.0 / 5.0);
            //Console.WriteLine(celcuisTemp);
            #endregion

        }//end Main()
    }//end class
}//end namespace
