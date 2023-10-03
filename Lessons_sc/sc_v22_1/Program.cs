namespace sc_v22_1
{
    // доп пример к видео 22
    // рисует прямоугольни заполненный случайными числами
    internal class Program
    {
        static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();
            var result = new int[rows, columns ];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 10;
            var myArray = GetRandomArray(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}