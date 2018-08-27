﻿using System;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            beginning:
            Console.WriteLine("Enter your first name");
            var firstName = Console.ReadLine();
            
            foreach (var letter in firstName)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("Enter your last name");
            var lastName = Console.ReadLine();
            var lastNameWithSpaces = "";

            foreach (var letter in lastName.ToUpper())
            {
                lastNameWithSpaces += letter + " ";
            }

            Console.WriteLine(lastNameWithSpaces.Trim());
            Console.WriteLine("Do you have a middle name? (y/n)");
            
            var hasMiddleName = Console.ReadLine();
            var middleName = "";

            if (hasMiddleName == "y")
            {
                Console.WriteLine("What is it?");
                middleName = Console.ReadLine();
                var i = 0;



                foreach (var letter in middleName)
                {
                    Console.WriteLine(letter.ToString().PadLeft(++i));
                }
            }
            else
            {
                Console.WriteLine($@"{firstName}, You are dumb and shouldn't have been born.

    


                     And your parents hate you. Press enter to be reborn to loving parents.");

                goto beginning;
            }

            Console.WriteLine($"Goodbye {firstName} {middleName} {lastName}.  Press enter to exit.");
            Console.ReadLine();
        }
    }
}
