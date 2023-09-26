namespace dz_sc_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;

            Console.WriteLine("Введите первое число диапазона");
            int firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число диапазона");
            int secondValue = int.Parse(
                if(Console.ReadLine() == null)0)
                    );

            
            while (firstValue <= secondValue) 
            {
                if (firstValue % 2 == 0)
                    oddNumbersCount++;
                else
                    evenNumbersCount++;
                
                firstValue++;
            }

            Console.WriteLine($"Колличество четных чисел: {evenNumbersCount}");
            Console.WriteLine($"Колличество нечетных чисел: {oddNumbersCount}");

        }
    }
}