using System;

namespace Lesson_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //1) Пользователь вводит пароль до тех пор, пока введенное значение не будет равно "Pass123!"

                Console.WriteLine();
                Console.WriteLine("Программа1");
                Console.WriteLine();
                Console.WriteLine("Введите пароль:");
                Console.WriteLine();

                string password = "";

                do
                {
                    password = Console.ReadLine();
                    Console.WriteLine();
                    if (password != "Pass123!")
                    {
                        Console.WriteLine("Доступ запрещён. Введите корректный пароль: ");
                        Console.WriteLine();
                    }
                    else
                    {
                    }
                }
                while (password != "Pass123!");
                Console.WriteLine("Доступ разрешён.");
                Console.WriteLine();


                //2) Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0 (больше 0 не встречается в последовательности). Найти самое большое число последовательности.

                Console.WriteLine();
                Console.WriteLine("Программа2");
                Console.WriteLine();
                Console.WriteLine("Введите последовательность чисел, заканчивающуся нулём: ");
                Console.WriteLine();

                int n = 0;
                int max = 0;

                do
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    
                    if (n > max)
                    {
                        max = n;
                    }
                    else
                    {
                        max = max;
                    }
                    Console.WriteLine();
                }
                while (n != 0);
                Console.WriteLine("Самое большое число последовательности: " + max + ".");
                Console.WriteLine();


                //3) Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0 (больше 0 не встречается в последовательности). Найти количество чисел в последовательности, которые делятся на 3, 7 или 11.

                Console.WriteLine();
                Console.WriteLine("Программа3");
                Console.WriteLine();
                Console.WriteLine("Введите последовательность чисел, заканчивающуся нулём: ");
                Console.WriteLine();

                int N;

                int quantity = 0;

                do
                {
                    N = Convert.ToInt32(Console.ReadLine());

                    if (N % 3 == 0 || N % 7 == 0 || N % 11 == 0)
                    {
                        quantity++;
                    }
                    Console.WriteLine();
                }
                while (N != 0);

                Console.WriteLine("Количество чисел в последовательности, которые делятся на 3, 7 или 11: " + quantity + ".");
                Console.WriteLine();

                
                //4) Пользователь вводит последовательность чисел неопределенной длины заканчивающуюся 0 (больше 0 не встречается в последовательности). Определить модуль суммы каких чисел больше, положительных или отрицательных.

                Console.WriteLine();
                Console.WriteLine("Программа4");
                Console.WriteLine();
                Console.WriteLine("Введите последовательность чисел, заканчивающуся нулём: ");
                Console.WriteLine();

                int numbers;

                int sumPositive = 0;
                int sumNegative = 0;

                do
                {
                    numbers = Convert.ToInt32(Console.ReadLine());

                    if (numbers > 0)
                    {
                        sumPositive += numbers;
                    }
                    else
                    {
                        sumNegative += numbers;
                    }
                    Console.WriteLine();
                }
                while (numbers != 0);

                string result1 = "Модуль суммы положительных чисел больше.";
                string result2 = "Модуль суммы отрицательных чисел больше.";
                string result3 = "Модули сумм положительных и отрицательных чисел равны.";

                if (Math.Abs (sumPositive) > Math.Abs (sumNegative))
                {
                    Console.WriteLine(result1);
                }
                else if (Math.Abs (sumPositive) < Math.Abs(sumNegative))
                {
                    Console.WriteLine(result2);
                }
                else
                {
                    Console.WriteLine(result3);
                }
                Console.WriteLine();


                Console.WriteLine();
                Console.WriteLine("Конец!");
                
                Console.ReadLine();
            }
        }
    }
}
