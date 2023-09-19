namespace sc_v14
{
    //ЛОГИЧЕСКИЕ ОПЕРАТОРЫ
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isInfected = true;

            if (!isInfected) // оператор "!"(НЕ)  инвертирует значение
            {
                Console.WriteLine("Персонаж инфецирован!");
            }

            // ================================================================
            int fanSpeed = 3000;

            bool isHightTemperature = true;
            bool hasNoCooling = fanSpeed <=0; // неявное задание булевой переменной

            // оператор && (И)
            // оператор || (ИЛИ)
            if (isHightTemperature && hasNoCooling)
            {
                Console.WriteLine("Перегрев!");
            }
            // ================================================================



        }
    }
}