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
            string characterName = "John";
            int characterAge = 35;

            Console.WriteLine("Hello World");

            Console.WriteLine($"There once was a man named {characterName}.");
            Console.WriteLine($"He was {characterAge} years old.");
            Console.WriteLine($"He really liked the name {characterName}.");
            Console.WriteLine($"But he did not like being {characterAge} years old.");

            Console.ReadLine();
        }
    }
}