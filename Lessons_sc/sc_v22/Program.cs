namespace sc_v22
{
    //ВЛОЖЕННЫЕ ЦИКЛЫ | КАК РАБОТАЮТ
    internal class Program
    {
        static void Main(string[] args)
        {
            // пример вложенных циклов

            //for (int i = 1; i <= 3;  i++)
            //{
            //    Console.WriteLine("Цикл 1 итерация № " + i);

            //    for (int j = 1; j < 4; j++)
            //    {
            //        Console.WriteLine("\tЦикл 2 итерация № " + j);

            //        for (int k = 1; k <= 2; k++)
            //        {
            //            Console.WriteLine("\t\tЦикл 3 итерация № " + k);
            //        }
            //    }
            //}

            // ======================================================================
            // Рисуем прямоугольник с помощью циклов

            Console.WriteLine("Введите высоту прямоугольника");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}                  