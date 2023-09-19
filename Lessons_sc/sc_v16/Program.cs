namespace sc_v16
{
    //ЦИКЛ WHILE
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            while (count < limit) 
            {
                count++;
                Console.WriteLine($"Lemrik {count}");
            }
        }
    }
}