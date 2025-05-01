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
            int size = 9;
            int[] array = new int[size]; 
            
            GetArrayFromConsole(array, ref size);
            
        }
       static int [] GetArrayFromConsole(int [] array, ref int size)
        {
            size = 6;
            int [] newarray = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите число номер {i + 1}: ");
                newarray[i] = int.Parse(Console.ReadLine());
            }
            return newarray;
        }
    }

}
