using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroApplication 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // string characterName = "John";
            // int characterAge = 35;

            // Console.WriteLine("Hello World");

            // Console.WriteLine($"There once was a man named {characterName}.");
            // Console.WriteLine($"He was {characterAge} years old.");
            // Console.WriteLine($"He really liked the name {characterName}.");
            // Console.WriteLine($"But he did not like being {characterAge} years old.");

            // Console.ReadLine();


            // Working with data types in C#
            // string phrase = "C# is new to me";
            // char grade = 'A';

            // int myNumber = 9;
            // double gpa = 3.9;

            // bool isMale = true;

            // Console.WriteLine("Giraffe\nAcademy");


            // Working with string in C#
            // string phrase = "Giraffe Academy";
            // Console.WriteLine(phrase.ToUpper());
            // Console.WriteLine(phrase.ToLower());
            // Console.WriteLine(phrase.Contains("Giraffe"));
            // Console.WriteLine(phrase.Substring(8, 7));

            // Working with numbers in C#
            // Console.WriteLine(50);
            // Console.WriteLine(5+8);
            // Console.WriteLine(5 / 2);
            // Console.WriteLine(5 / 2.0); 


            // Work with user input in C#
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine($"Hello {name}, you are {age} years old.");

            int num = Convert.ToInt32("48");
        }
    }
}