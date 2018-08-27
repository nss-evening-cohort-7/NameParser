using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Stuff
{
    class Thing
    {
        int _myNumber = 1;

        public int MyProperty { get; set; }

        public void AssignTheNumber(int myNumber)
        {
            _myNumber = myNumber;
        }
        
        string GetStuff()
        {
            var x = _myNumber;

            return "stuff";
        }
    }
}
