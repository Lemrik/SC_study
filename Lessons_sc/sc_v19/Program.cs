namespace sc_v19
{
    //C# ЦИКЛ FOR | В ОБРАТНОМ ПОРЯДКЕ | НЕСКОЛЬКО ПЕРЕМЕННЫХ | НЕСКОЛЬКО УСЛОВИЙ | # 19
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            // работа двух циклов в связке
            for (; i < 3; i++)
            {
                Console.WriteLine("for_1: " + i);
            }
            for (; i < 5; i++)
            {
                Console.WriteLine("for_2: " + i);

            }
            
            // несколько инкрементов
            for (int j = 0, k = 5; j < 10; j++, k++)
            {
                Console.WriteLine("j: " + j);
                Console.WriteLine("k: " + k);
            }

            // несколько условий
            for (int j = 0, k = 5; j < 9 && k < 12; j++)
            {
                Console.WriteLine("j: " + j);
                Console.WriteLine("k: " + k);
            }

            // цикл for в обратном порядке
            int j = int.Parse(Console.ReadLine());
            for (; j >= 0; j--)
            {
                Console.WriteLine(j);
            }
        }
    }
}