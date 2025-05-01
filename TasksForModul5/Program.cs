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
            int[] array = new int[] { -48, 89, -9, 225, -58, -2, 199 };
            int[] sortedDesc;
            int[] sortedAsc;

            SortArray(array, out sortedDesc, out sortedAsc);

            Console.WriteLine("Исходный массив:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Отсортированный по возрастанию:");
            foreach (int element in sortedAsc)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Отсортированный по убыванию:");
            foreach (int element in sortedDesc)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void SortArray(in int[] array, out int[] sortedDesc, out int[] sortedAsc)
        {
            sortedDesc = SortArrayDesc(array);
            sortedAsc = SortArrayAsc(array);
        }

        static int[] SortArrayAsc(in int[] array)
        {
           
            int[] result = (int[])array.Clone();
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
            return result;
        }

        static int[] SortArrayDesc(in int[] array)
        {
           
            int[] result = (int[])array.Clone();
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
            return result;
        }
    }

}
