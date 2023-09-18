namespace sc_v11_2
{
    /*
     Введите три числа и выведите на эран значение суммы и произведения этих чисел
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите число 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 3");
            thirdValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdValue;
            Console.WriteLine($"Сумма = {sumResult}");

            double multResuly = firstValue * secondValue * thirdValue;
            Console.WriteLine($"Произведение = {multResuly}");
        }
    }
}