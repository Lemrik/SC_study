namespace sc_v20
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // КЛЮЧЕВОЕ СЛОВО BREAK | ОПЕРАТОР BREAK
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }

            Console.WriteLine("===========");

            //КЛЮЧЕВОЕ СЛОВО CONTINUE | ОПЕРАТОР CONTINUE
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}