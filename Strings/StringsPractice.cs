using System;

namespace StringsPractice
{
    class StringsPractice
    {
        static void Main(string[] args)
        {
            string aliceInWonderland = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine(aliceInWonderland + "\n");

            Console.WriteLine("What is your search term?");
            string searchTerm = Console.ReadLine();

            int location = aliceInWonderland.ToLower().IndexOf(searchTerm.ToLower());

            Boolean searchFound = location > -1;

            Console.WriteLine("Search term found: " + searchFound.ToString());
            Console.WriteLine("Index: " + location.ToString());
            Console.WriteLine("Length: " + searchTerm.Length.ToString());

            string aliceMinusTerm = aliceInWonderland.Substring(0, location) + aliceInWonderland.Substring(location + searchTerm.Length, aliceInWonderland.Length - location - searchTerm.Length);

            Console.WriteLine(aliceMinusTerm);
        }
    }
}

