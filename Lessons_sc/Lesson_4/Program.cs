namespace Lesson_4
{
    internal class Program
    {
        static void Main()
        {
            string name = "Tom";
            int age = 34;
            double height = 1.7;

            //Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");

            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int result = 0;

            foreach (int number in numbers)
            {
                if (number > 0)
                    result++;
            }
            Console.WriteLine(result);

            int n = numbers.Length;
            int k = n / 2;
            int temp;
            for (int i = 0; i < k; i++)
            {
                temp = numbers[i]; 
                numbers[i] = numbers[n - i - 1];
                numbers[n - i - 1] = temp;
            }
            foreach (int i in numbers)
            { 
                Console.WriteLine(i);
            }

        }
    }
}