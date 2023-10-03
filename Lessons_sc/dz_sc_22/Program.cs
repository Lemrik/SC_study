namespace dz_sc_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый катет");
            int firstCatet = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второй катет");
            int secondCatet = int.Parse(Console.ReadLine());

            for (int i = 0; i < firstCatet; i++)
            {
                Console.Write("#");
                for (int j = 1; j < secondCatet; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}