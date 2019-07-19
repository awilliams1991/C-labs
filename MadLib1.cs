using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib1
    {
        static void Main()
        {
            Console.WriteLine("Fun with MadLibs");
            Console.Title = "Fun with MadLibs";

            Console.WriteLine("As a reminder nouns are people, places, and things. Verbs are actions. Adjectives are describing words.\n");

            Console.Write("Pick a noun: ");
            string noun1 = Console.ReadLine();
            Console.Write("Pick a verb: ");
            string verb1 = Console.ReadLine();
            Console.Write("Pick an adjective: ");
            string adj1 = Console.ReadLine();
            Console.Write("Pick another noun: ");
            string noun2 = Console.ReadLine();
            Console.Write("Pick an -ing verb: ");
            string ingVerb = Console.ReadLine();
            Console.Write("Pick another adjective: ");
            string adj2 = Console.ReadLine();
            Console.Write("Use a short statement with an exclamation point: ");
            string exclamation = Console.ReadLine();
            Console.Write("Pick a city: ");
            string city = Console.ReadLine();
            Console.Write("What time is this happening? ");
            string time = Console.ReadLine();


            Console.WriteLine($"One day there was a {noun1} that didn't want to {verb1} anymore. {noun1} went to the " +
                $"{adj1} building.\n In the {adj1} building {noun1} met {noun2} to say hello.\n After meeting with {noun1}, {noun2} went" +
                $" {ingVerb}. In the park {noun2} saw a {adj2} bird.\n {exclamation} said {noun2}. {noun2} decided that they were glad " +
                $"that they came to {city}.\n Soon it was {time} and {noun2} needed to go back home.\n");


        }//end Main()
    }//end class
}//end namespace
