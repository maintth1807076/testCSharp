using System;
using System.Text.RegularExpressions;
using TestCSharp.exercise1;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
//            Exercise1
            var person = new People
            {
                Name = "Marry",
                Gender = true,
                Age = 25,
            };
            Console.WriteLine(person);
            person.Age += 10;
            Console.WriteLine(person);
            
            
//            Exercise2
            Console.WriteLine("Enter a String: ");
            var str = Console.ReadLine();
            Console.WriteLine("Enter a word to search: ");
            var word = Console.ReadLine();
            var count = Regex.Matches(str, word, RegexOptions.IgnoreCase).Count;
            Console.WriteLine($"Word found {count} times in the string.");
        }
        
    }
}