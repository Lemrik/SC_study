namespace sc_v29
{
    // ДВУМЕРНЫЙ МАССИВ В C# | МНОГОМЕРНЫЕ МАССИВЫ 
    // ДВУМЕРНЫЙ МАССИВ | ОБЪЯВЛЕНИЕ | ИНИЦИАЛИЗАЦИЯ | ИНДЕКСЫ
    // ВЫВОД ДВУМЕРНОГО МАССИВА
    internal class Program
    {
        static void Main(string[] args)
        {
            // инициализация тип_данных[,] имя массива
            int[,] myArray;
            myArray = new int[3, 5]
            {
                {2,4,5,6,7 },
                {11,23,44,51,6},
                {13,1,41,53,7}
            };

            Console.WriteLine(myArray[0,2]);

            // показывает сколько измерений у массива
            Console.WriteLine(myArray.Rank);

            Console.WriteLine("\n");

            // получаем кол-во элементов в каждом измерении
            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(myArray[y,x]+ " ");
                }
                Console.WriteLine();
            }


        }
    }
}