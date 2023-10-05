using System.Runtime.ExceptionServices;

namespace dz_sc_26_1
{
    // заполнить массив с клавиатуры
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива (число!)");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}