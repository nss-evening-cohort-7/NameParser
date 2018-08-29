using System;
using System.Dynamic;
using NameParser.Names;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = new FirstName();
            var middleName = new MiddleName(firstName);
            var lastName = new LastName();

            firstName.GetName();
            firstName.PrintName();

            lastName.GetName();
            lastName.PrintName();

            middleName.GetName();
            middleName.PrintName();
            
            Console.WriteLine($"Goodbye {firstName.Name} {middleName.Name} {lastName.Name}.  Press enter to exit.");
            Console.ReadLine();
        }
    }
}
