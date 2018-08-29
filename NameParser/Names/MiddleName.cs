using System;

namespace NameParser.Names
{
    class MiddleName
    {
        private readonly FirstName _firstName;

        public string Name { get; private set; }

        public MiddleName(FirstName firstName)
        {
            Name = "";
            _firstName = firstName;
        }

        public void GetName()
        {
            if (UserHasMiddleName())
            {
                Console.WriteLine("What is it?");
                Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($@"{_firstName.Name}, that's fine.");
            }
        }

        bool UserHasMiddleName()
        {
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }

        public void PrintName()
        {
            var i = 0;

            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }
    }
}
