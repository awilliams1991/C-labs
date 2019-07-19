using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoops2
    {
        static void Main()
        {
            Console.WriteLine("Now add one . for each index of the fruit list");
            Console.Title = "FruitLoops 2";
            //one solution with correct output
            string[] fruitArr = { "strawberries", "blueberries", "mango", "banana", "kiwi", "star fruit" };
            string[] dotsArr = { ".", "..", "...", "....", ".....", "......" };
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(fruitArr[i]);
                Console.WriteLine(dotsArr[i]);
            }//end for

            //****Ask Chris can you do loops with char? becuase the dots can't be changed numerically and it 
            //would require quite
            //a bit of code to create a loop or solution of some sort as it would need a case for each set of .


            string[] fruitArr2 = { "strawberries", "blueberries", "mango", "banana", "kiwi", "star fruit" };
            int x = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(fruitArr2[i]);
                //while (x <= i)
                //{
                // Console.WriteLine(".");//only giving me one . need it to give me one more each loop
                // x++;//may not be possible with a while loop

                //}//end while
                for (int y = 0; y < 6; y++)
                {
                    Console.WriteLine(".");//giving me 6 . on each
                    x++;
                }//end for
            }//end for


        }//end Main()
    }//end class
}//end namespace
