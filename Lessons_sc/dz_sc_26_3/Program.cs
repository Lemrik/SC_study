namespace dz_sc_26_3
{
    // найти сумму четных числе элементов в массиве
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Введите длину массива");
                int length = int.Parse(Console.ReadLine());

                int[] array = new int[length];

                Console.WriteLine();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(0, 10);
                    Console.Write($"{array[i]} ");
                }

                int sumChet = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        sumChet += array[i];
                    }
                }

                Console.WriteLine($"\n\nСумма четных чисел = {sumChet}");

                Console.WriteLine("\n\nНажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}