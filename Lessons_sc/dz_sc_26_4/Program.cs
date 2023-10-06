namespace dz_sc_26_4
{
    // найти наименьшее число в массиве
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

                int minValue = array[0];

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < minValue)
                    {
                        minValue = array[i];
                    }
                }


                Console.WriteLine($"\n\nНаименьшее число в массиве = {minValue}");

                Console.WriteLine("\n\nНажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}