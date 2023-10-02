namespace sc_v22
{
    //ВЛОЖЕННЫЕ ЦИКЛЫ | КАК РАБОТАЮТ
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3;  i++)
            {
                Console.WriteLine("Цикл 1 итерация № " + i);

                for (int j = 1; j < 5; j++)
                {
                    Console.WriteLine("Цикл 2 итерация № " + j);
                }
            }
        }
    }
}                  