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
            (string Name, string[] Dishes) User;

            Console.Write("Введите ваше имя: ");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.Write($"Введите название блюда номер {i + 1}: ");
                User.Dishes[i] = Console.ReadLine();
            }
        }
    }
}
