using System;
using System.Collections.Generic;

namespace DictionaryOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Impervious", "The feeling of students when they are unable to be affected by noise.");
            wordsAndDefinitions.Add("Disingenuous", "When students lie about completing their homework.");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine($"Awesome: {wordsAndDefinitions["Awesome"]}");
            Console.WriteLine($"Disingenuous: {wordsAndDefinitions["Disingenuous"]}");
            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
            // Console.WriteLine("Hello World!");
        }
    }
}
