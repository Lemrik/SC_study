namespace dz_sc_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Введите катет");
                int catet = int.Parse(Console.ReadLine());

                Console.WriteLine();

                // первый треугольник
                for (int i = 0; i <= catet; i++)
                {

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                // второй треугольник
                for (int i = catet; i >= 0; i--)
                {

                    for (int j = i; j > 0; j--)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }


                // третий треугольник
                for (int i = 0; i < catet; i++)
                {
                    for (int j = catet; j > (i + 1); j--)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                // четвертый треугольник
                for (int i = catet; i > 0; i--)
                {
                    for (int j = catet; j > i; j--)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }


                Console.WriteLine("\nНажмите любую клавишу для отчистки консоли");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}