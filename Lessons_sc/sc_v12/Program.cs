﻿namespace sc_v11
{
    /*
     Инкремент и декремент. Постфиксный и префиксный.
     */

    // инкремент бывает префиксным: ++x - сначала значение переменной x увеличивается на 1, а потом ее значение возвращается в качестве результата операции.

    // И также существует постфиксный инкремент: x++ - сначала значение переменной x возвращается в качестве результата операции, а затем к нему прибавляется 1.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Это унарный вид операций
            int a = 0;

            // Префиксный выполняется после
            // Инкремент префиксный
            --a; // тоже самое, что и a = a + 1;
            // Декремент префиксный
            --a; // тоже самое, что и a = a - 1;


            // Постфиксный выполняется после
            // Инкремент постфиксный
            a++; // тоже самое, что и a = a + 1;
            // Декремент постфиксный
            a--; // тоже самое, что и a = a - 1;


        }
    }
}