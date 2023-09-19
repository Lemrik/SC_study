using System.Diagnostics;

namespace sc_v15
{
    //SWITCH C#
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());


            switch (a)
            {
                case 1:
                    Console.WriteLine("Вы ввели чсило 1");
                    break;
                case 2:
                    Console.WriteLine("Вы ввели чсило 2");
                    break;
                default: Console.WriteLine($"Вы ввели чсило {a}");
                    break;
            }
        }
    }
}