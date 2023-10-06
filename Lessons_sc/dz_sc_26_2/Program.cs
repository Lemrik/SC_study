namespace dz_sc_26_2
{
    // вывести массив в обратном порядке
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
                    array[i] = new Random().Next(0, 100);
                    Console.Write($"{array[i]} ");
                }

                Console.WriteLine("\n\n");

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{array[i]} ");

                }

                Console.WriteLine("\n\nНажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
            

        }
    }
}