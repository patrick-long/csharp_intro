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
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            // Console.Write("Enter your age: ");
            // string age = Console.ReadLine();
            // Console.WriteLine($"Hello {name}, you are {age} years old.");

            // int num = Convert.ToInt32("48");

            // Working with arrays in C#
            // int [] luckyNumbers = {2, 3, 4, 9};
            // string[] friends = new string[5];
            // friends[0] = "Patrick";
            // friends[1] = "Abigayle";

            // SayHello("Patrick", 23);

            // Console.WriteLine(cubeNumber(3));
            
            // Start working with if statements in C#
            // bool isMale = false;
            // if (isMale) 
            // {
            //     Console.WriteLine("You are male");
            // } else 
            // {
            //     Console.WriteLine("You are not male");
            // }

            // Creating a better calculator with C#
            Console.Write("Enter a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another number:" );
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+") 
            {
                Console.WriteLine(number1 + number2);
            } else if (op == "-") 
            {
                Console.WriteLine(number1 - number2);
            } else if (op == "*")
            {
                Console.WriteLine(number1 * number2);
            } else if (op == "/") 
            {
                Console.WriteLine(number1 / number2);
            } else 
            {
                Console.WriteLine("Invalid operator");
            }
        }

        // Start creating methods in C#
        // static void SayHello(string name, int age)
        // {
        //     Console.WriteLine($"Hello {name}, you are {age}");
        // }

        // Start working with return statements in C# methods
        // static void cubeNumber(int num)
        // {
        //     return num*num*num;
        // }


    }
}