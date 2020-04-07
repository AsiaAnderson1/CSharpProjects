using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibAMA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maddest MadLib Getting You Mad");
            Console.WriteLine();

            String adj1;
            String monsters;
            String president;
            String verb;
            String place;

            Console.WriteLine("Give the name of a magical land.");
            place = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Name a President. ");
            president = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Give one adjective.");
            adj1 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Name the scariest monsters.");
            monsters = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Type a action verb");
            verb = Console.ReadLine();



            Console.WriteLine();



            Console.Write("One day in  ");
            Console.Write(place);
            Console.Write(" , ");
            Console.Write(president);
            Console.Write(" was running away from  ");
            Console.Write(monsters);
            Console.Write(". He ran for his life. Then he approached a ");
            Console.Write(adj1);
            Console.Write(" wall with a gatekeeper. \"Help!\" He screamed.  The gatekeeper ignored. \"You don't see that I need help?!\" The putrid smells of rotting flesh permeated his nose as the ");
            Console.Write(monsters);
            Console.Write(" howled at his neck. Unmoved the gatekeeper yells out, \"But first! A trade deal.\" ");
            Console.Write(president);
            Console.WriteLine(" stood bewildered and confused, as zombies began to ");
            Console.Write(verb);
            Console.Write(" on his toupee.");

            Console.ReadKey();
            {
            }
        }
    }
}