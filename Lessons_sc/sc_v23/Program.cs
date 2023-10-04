namespace sc_v23
{
    // ТЕРНАРНЫЙ ОПЕРАТОР 
    // выполняет действия над тремя операндами
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 0;

            // унарный оператор
            a++;

            // бинарный оператор
            a = a + 1;

            // тернарный оператор
            // [первый операнд - условие] ? [второй операнд if_true] : [третий операнд if_else]
            while (true)
            {

                bool accessAllowed;

                Console.WriteLine("Введите пароль: ");

                string storedPassword = "qwerty";
                string enteredPassword = Console.ReadLine();

                //if (storedPassword == enteredPassword)
                //{
                //    accessAllowed = true;
                //}
                //else  
                //{
                //    accessAllowed = false;
                //}

                // тоже самое

                accessAllowed = storedPassword == enteredPassword ? true : false;

                Console.WriteLine(accessAllowed);
                Console.ReadKey();
            }
        }
    }
}