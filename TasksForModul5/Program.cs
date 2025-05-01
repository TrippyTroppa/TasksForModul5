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
            Console.WriteLine(phrase);
            if (deep > 1)
            {
                Echo (phrase, deep - 1);
            }
                
        }
           
    }
}
