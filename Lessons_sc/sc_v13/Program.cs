namespace sc_v13
{
    // 12ый - операторы сравнения, опускаем
    //IF ELSE
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isInfected = true;

            if (isInfected) 
            {
                Console.WriteLine("Персонаж инфецирован!");
            }
            else 
            {
                Console.WriteLine("Персонаж здоров!");
            }

            int a = 5;

            if (a == 5)
            {
                Console.WriteLine($"а равно {a}");
            }
            else 
            {
                Console.WriteLine($"а не равно {a}");
            }
        }
    }
}