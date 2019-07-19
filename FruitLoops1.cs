using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoops1
    {
        static void Main()
        {
            Console.WriteLine("Declare and initialize 6 kinds of fruit and using a for loop print each one to the screen");
            Console.Title = "Fruit Loops";
            #region
            //pick 6 fruits and initalize them to string[] call fruits
            //write a for loop set to run six times to print each fruit
            //you are not nice people--this would be infinitely easier using a for each loop


            /*string[] fruitArr = new string[6];
            fruitArr[0] = "Strawberries";
            fruitArr[1] = "blueberries";
            fruitArr[2] = "mango";
            fruitArr[3] = "banana";
            fruitArr[4] = "kiwi";
            fruitArr[5] = "star fruit";
            */
            #endregion

            string[] fruitArr = { "strawberries", "blueberries", "mango", "banana", "kiwi", "star fruit"};

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(fruitArr[i]);
            }//end for


            #region
            //correct code: declare your list with its datatype. initialize the values in the arry.

            /*
             * for loops don't like strings. In order for this to work you have to call to the correct index of the array to 
             * display each fruit. i is a standard placeholder. by assigning it the value zero we can use it to represent the index
             * we only have 6 fruits in the list and the last index is 5 since it is zero based. using the unary operator
             * we add one to i with each pass. Using the console writeline we use i to call the index the loop is on to display to 
             * the screen.
             * */


            #endregion
        }//end Main()
    }//end class
}//end namespace
