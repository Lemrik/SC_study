namespace sc_v18
{
    // for
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите лимит");
            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);

                Thread.Sleep(100);
            }
        }
    }
}