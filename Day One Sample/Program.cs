﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_One_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //SampleCode();
            //Here is a single line comment. Ctrl+K+C adds comments. Ctrl+K+U uncomments your code.
            /* Here are some
             * Multiline
             * Comments. 
             * Use Slash & Asterisk
             */

            Console.ReadKey();
        }

        static void SampleCode()
        {
            Console.WriteLine("Hello Ninja!");
            Console.WriteLine("Hello " + "Ninja!");
            Console.Write("What is your name? ");
            string yourName = Console.ReadLine();
            Console.WriteLine($"Hello {yourName}.");

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            Console.Write("How many hours of sleep did you get last nite? ");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("Good job. That's a lot of sleep.");
            }
            else if (hoursOfSleep >= 6)
            {
                Console.WriteLine("Not bad, but you need more.");
            }
            else if (hoursOfSleep < 6)
            {
                Console.WriteLine("Dude you need more sleep.");
            }
            else
            {
                Console.WriteLine("I don't know what you wrote.");
            }
        }

    }
}
