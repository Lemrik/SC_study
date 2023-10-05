namespace sc_v24
{
    // ОДНОМЕРНЫЙ МАССИВ
    // ИНИЦИАЛИЗАЦИЯ МАССИВА
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5] {1,4,5,7,87};

            // создает коллекцию из 10 пятёрок и добавляет все в массив при его инициализации
            int[] myArray2 = Enumerable.Repeat(5, 10).ToArray();
            // создает коллекцию из 5 элементов, начиная с 4, т.е. будеи 4,5,6,7,8
            int[] myArray3 = Enumerable.Range(4, 5).ToArray();


            myArray[1] = 3;
            Console.WriteLine(myArray[1]);

        }
    }
}