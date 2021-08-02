using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitlyTypedLocalVars
{
    class Dwhil
    {
        protected static void DW()
        {
            string userIsDone = "";
            // Test on a lower-class copy of the string.
            while(userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while Loop");

            }
        }
    }
}
