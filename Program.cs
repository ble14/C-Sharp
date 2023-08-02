﻿using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 24;
            string name = "Brandon";
            int height = 68;

            //1. string concatination
            Console.WriteLine("String concatination");
            Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");

            //2. String formatting
            // string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine
            ("Hello, my name is {0}, and I am {1} years old and I'm {2} inches tall.",
            name, age, height);

            //3. String interpolation
            // String Interpolation uses $ at the start which will allows us to write our
            // variables like this: {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello, my name is {name}, and I am {age} years old.");

            //4. Verbatim strings
            // verbatim strings start with the @ and tells the compiler to take
            // the string literally and ignore any spaces and escape characters like \n
            // \n is for line breaks in text strings
            Console.WriteLine("String Interpolation");
            Console.WriteLine(@"Since the release of the first novel, Harry Potter and the Philosopher's Stone, on 26 June 1997, 
            the books have found immense popularity, positive reviews, and commercial success worldwide. 
            They have attracted a wide adult audience as well as younger readers and are widely considered cornerstones of modern literature.[4][5] 
            As of February 2023, the books have sold more than 600 million copies worldwide, making them the best-selling book series in history, 
            and have been available in 85 languages.[6] The last four books consecutively set records as the fastest-selling books in history, 
            with the final instalment selling roughly 2.7 million copies in the United Kingdom and 8.3 million copies in the United States within 
            twenty-four hours of its release.");

            // instead of using \\ to write file paths we can use verbatim strings to make it easier
            // if you remove the @ you'll get an error because \U, \A, and \D are not valid escape characters
            // can be used for when you want to enter a file path on your computer
            Console.WriteLine(@"C:\Program Files\dotnet\shared\Microsoft.NETCore.App");

        }
    }
}