namespace sc_v28
{
    // ИНДЕКСЫ И ДИАПАЗОНЫ В C#8
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 10, 5, 6, 77, 89 };

            // получить элементы с 1 по 4ый элементы 4ЫЙ НЕ БЕРЕТ!!!!!!!!
            int[] myArray2 = myArray[1..4];

            // тоже самое, но с начала
            myArray2 = myArray[0..4];

            // с пятого включительно и до конца
            myArray2 = myArray[5..];

            // получить первый элемент с конца массива
            Console.WriteLine(myArray[^1]);

            Index myIndex = ^1;
            Console.WriteLine($"value {myIndex.Value}, isFromEnd {myIndex.IsFromEnd}");

            // создать индекс, который ищет 3ий элемени с конца
            Index myIndex2 = new Index(3, true); // ^3

            // создать диапазон с 4ого с конца до первого с конца
            Range myRange = new Range(^4,^1);

            // цикл foreach базовый пример перебора массива
            foreach (var item in myArray)
                Console.WriteLine(item);
        }
    }
}