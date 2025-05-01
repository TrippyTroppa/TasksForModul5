using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = 81;
            Console.WriteLine(age);

            ChangeAge(age);

            Console.WriteLine(age);

        }
       static void ChangeAge (int myage)
        {
            Console.Write("Введите ваш возраст:");

            myage = Convert.ToInt32(Console.ReadLine());
        }
    }

}
