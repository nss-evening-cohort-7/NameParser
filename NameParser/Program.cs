using NameParser.Stuff;
using System;

namespace NameParser
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var x = new Thing();
            var y = new Thing();

            x.MyProperty = 4;
            Console.WriteLine(x.MyProperty);
            
            y.AssignTheNumber(1110);

            Console.ReadLine();
        }
    }
}
