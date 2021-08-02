using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitlyTypedLocalVars
{
    class Foreach
    {
        public static void Cars()
        {
            string[] carType = { "ford", "BMW","YUgo","Honda" };
            foreach (string c in carType)
            {
                Console.WriteLine(c);
            }
            
        }

        public static void Num()
        {
            int[] myInt = { 10, 20, 30, 40 };
            foreach (int i in myInt) {
                Console.WriteLine(i);
            }
        }
    }
}
