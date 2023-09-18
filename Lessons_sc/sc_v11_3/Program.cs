namespace sc_v11_3
{
    /*
     Напишите простой конвертер валют
     (без возможности динамического выбора валюты пользователем.)
     Валюты заданы хардкодом и не имзменяются. Тип валют на выбор программиста.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double usdToRub = 96.85;
            double usdValue;

            Console.WriteLine($"Введите сумму в USD");

            usdValue = double.Parse(Console.ReadLine());

            Console.WriteLine(usdValue + " USD в RUB = " + usdValue * usdToRub);
        }
    }
}