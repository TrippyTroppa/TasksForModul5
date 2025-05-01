using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то...");

            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");

            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);
        }
        static void Echo(string phrase, int deep)
        {
            string modif = phrase;

            if (modif.Length > 2)
            { 
            modif = modif.Remove(0, 2);
                 
            }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine($"...{modif}");


            if (deep > 1)
            {
                Echo (modif, deep - 1);
            }
                
        }
           
    }
}
