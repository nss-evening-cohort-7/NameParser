using System;

namespace NameParser.Names
{
    class LastName : NameBase
    {
        public FirstName FirstName { get; }
        
        public LastName() : base("last")
        {}

        public LastName(FirstName firstName) : this()
        {
            FirstName = firstName;
        }

        public override void PrintName()
        {
            var lastNameWithSpaces = "";

            foreach (var letter in Name.ToUpper())
            {
                lastNameWithSpaces += letter + " ";
            }

            Console.WriteLine(lastNameWithSpaces.Trim());
        }

    }
}
