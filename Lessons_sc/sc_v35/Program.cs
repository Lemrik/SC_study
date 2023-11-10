namespace sc_v35
{
    // C# ФУНКЦИИ И МЕТОДЫ
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = Sum(5, 7);
            Console.WriteLine(c);

            PrintLine();

            PrintResult(4, 6);
        }

        static int Sum(int a, int b)
        {
            int result = a + b;

            return result;
        }

        static void PrintLine()
        {
            Console.WriteLine("Метод PrintLine");
        }

        static void PrintResult(int value_1, int value_2)
        {
            int result = value_1 + value_2;
            Console.WriteLine("Результат метода: " + result);
        }
    }
}