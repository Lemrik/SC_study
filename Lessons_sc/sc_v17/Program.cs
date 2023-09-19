namespace sc_v17
{
    //ЦИКЛ DO WHILE
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            // выполнится хотябы 1 раз
            do 
            { 
                count++;
                Console.WriteLine(count);
            } 
            while (count < 5);

        }
    }
}