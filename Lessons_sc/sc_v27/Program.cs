namespace sc_v27
{
    // КАК РАБОТАТЬ С МАССИВАМИ В C# НА САМОМ ДЕЛЕ
    // LINQ
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

                int result = array.Max();
                Console.WriteLine($"\n\nМаксимальное значение в массиве {result}");

                result = array.Min();
                Console.WriteLine($"\n\nМинимальное значение в массиве {result}");

                result = array.Sum();
                Console.WriteLine($"\n\nСумма всех значений {result}");

                result = array.Where(i => i % 2 == 0).Sum();
                Console.WriteLine($"\n\nСумма всех четных значений {result}");

                result = array.Where(i => i % 2 != 0).Min();
                Console.WriteLine($"\n\nНаименьшее не четное число {result}");

                // поместить уникальные элементы из одного массива в другой
                int[] resultArray = array.Distinct().ToArray();

                // поместить отсортированные элементы старого массива в новый
                resultArray = array.OrderBy(i => i).ToArray();

                // поместить в массив все числа из другого массива, которые меньше 10
                resultArray = array.Where(i => i < 10).ToArray();

                // найти первое число, которое меньше 10, если его нету, до дефолтное значение
                result = array.Where(i => i < 10).FirstOrDefault();

                // найти первое число с конца, которое меньше 10, если его нету, до дефолтное значение
                result = array.Where(i => i < 10).Last();

                // стандарное обращение через класс Array

                result = Array.Find(array, i => i < 5);
                Console.WriteLine($"\n\nПервый элемент с НАЧАЛА который меньше пяти {result}");

                result = Array.FindLast(array, i => i < 5);
                Console.WriteLine($"\n\nПервый элемент с КОНЦА который меньше пяти {result}");

                result = Array.FindIndex(array, i => i < 5);
                Console.WriteLine($"\n\nНаходит индекс элемента по условию с начала {result}");

                result = Array.FindLastIndex(array, i => i < 5);
                Console.WriteLine($"\n\nНаходит индекс элемента по условию с конца {result}");

                // находит ВСЕ элементы, которые меньше пяти и добавляет в массив
                resultArray = Array.FindAll(array, i => i == 5);

                // массив в обратном порядке
                Array.Reverse(array);


                Console.WriteLine("\n\nНажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}