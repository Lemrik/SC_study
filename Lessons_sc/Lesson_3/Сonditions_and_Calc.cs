using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Lesson_3
{
    internal class Сonditions_and_Calc
    {
        static void Main()
        {
            //===========================================================================================================
            // Условия (начало)
            //===========================================================================================================

            //if \ else
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2) //(утверждение или выражение)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }

            // можно без else
            else
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }

            //switch \ case
            Console.WriteLine("Нажмите Y или N");
            string selection = Console.ReadLine();
            switch (selection)

            {
                case "Y":
                //Console.WriteLine("Вы нажали букву Y");
                // если нет конструкции break, тогда мы зайдем в кейс 1 и кейс 2
                case "N":
                    Console.WriteLine("Вы нажали букву N");
                    break;
                default: // выполнится этот блок если не будет совпадений
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }

            // тернарная операция условия (жуть какая)
            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмите + или -");
            string select = Console.ReadLine();

            int z = select == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);

            //===========================================================================================================
            // Условния(конец)
            //===========================================================================================================

            //===========================================================================================================
            // Калькулятор(начало)
            //===========================================================================================================

            while (1 == 1)
            {

                Console.Clear();
                double buttonValue_1, buttonValue_2;
                string buttonAction;
                double result = 0; // почему-то если не присвоить значение, то не выводит переменную после свитча :С

                try
                {
                    Console.WriteLine("Введите первое число");
                    buttonValue_1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите действие");
                    buttonAction = Console.ReadLine();
                    Regex regex = new Regex(@"[-+*/]");

                    if (!regex.IsMatch(buttonAction))
                        throw new Exception("Введено не верное действие");


                    Console.WriteLine("Введите второе число");
                    buttonValue_2 = double.Parse(Console.ReadLine());
                    bool sas = double.TryParse(Convert.ToString(buttonValue_2), out result);
                    Console.WriteLine(sas);

                    if (!sas)
                        throw new Exception("suck");

                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Не верный формат значений, нажмите любую клавишу");

                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    continue; // перенесет в начало цикла
                }

                switch (buttonAction)
                {

                    case "+":
                        result = buttonValue_1 + buttonValue_2;
                        break;
                    case "-":
                        result = buttonValue_1 - buttonValue_2;
                        break;
                    case "*":
                        result = buttonValue_1 * buttonValue_2;
                        break;
                    case "/":
                        result = buttonValue_1 / buttonValue_2;
                        break;
                    case "%":
                        result = buttonValue_1 % buttonValue_2;
                        break;

                }

                Console.WriteLine("Результат: " + buttonValue_1 + " " + buttonAction + " " + buttonValue_2 + " = " + result);
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();

            }

            //===========================================================================================================
            // Калькулятор (конец)
            //===========================================================================================================
        }
    }
}
