using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitlyTypedLocalVars
{
    class Switch
    {
       public static void SwitchExample()
        {
            Console.WriteLine("1[C#], 2[VB]");
            Console.WriteLine("Please pick your Language preference");

            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);

            switch ( n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is fine language");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more");
                    break;
                default:
                    Console.WriteLine("welcome ... good , luck with that");
                    break;
            }       
        }
    }
}
