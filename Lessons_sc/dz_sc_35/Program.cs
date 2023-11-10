namespace dz_sc_35
{
    internal class Program
    {
        // 1
        // Написать метод, который выводит на экран строку.
        // Символы из которых состоит строка и их количество вводятся пользователем

        // 2
        // Написать метод для поиска индекса элемента массива (тип элементов в массиве -int),
        // метод должен вернуть индекс первого найденного элемента (если он будет найден)
        static void Main()
        {
            // 1
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            PrintString(a, b);

        }

        // 1
        static void PrintString(string symb, int col)
        {
            string result = "";
            for (int i = 0; i < col; i++)
            {
                result = result + symb;
            }
            Console.WriteLine(result);
        }

        //static int SearchIndex(int c) 
        //{
        //    int[] arr;
            
        //    foreach (int i in c)
        //    {

        //    }
        //}
    }
}