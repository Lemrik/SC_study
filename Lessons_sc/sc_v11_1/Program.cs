namespace sc_v10_1
{
    /*
     Напишите программу, вычисляющую среднее арифмитическое двух чисел.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Введите число 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;

            Console.WriteLine($"среднее арифмитическое двух чисел = {result}");
        }
    }
}