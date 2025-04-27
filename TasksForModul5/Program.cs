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
            int[] array = GetArrayFromCosole();
            array = SortArray(array);
        }
        static int[] GetArrayFromCosole(int num = 5)
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"Введите число номер {i + 1} масива: ");
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;


        }
        static int[] SortArray(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;

                    }

            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);
            return result;
        }
    }

}
