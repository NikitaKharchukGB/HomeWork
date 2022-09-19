using System;

namespace HWCS4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            // Exponentiation();

            // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            // SumNumber();

            // Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран. Пользователь вводит число элементов в массиве,
            //  минимальное, и максимальное значение. Надо заполнить массив рандомными данными от минимального до максимального значение.
            // И важное уточнение: делать все в методе который возвращает массив.
            // ShowArray();
        }

        // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        // 3, 5 -> 243 (3⁵)
        // 2, 4 -> 16
        static void Exponentiation()
        {
            Console.Write("Введите первое число: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число, оно должно быть натуральным: ");
            int degree = int.Parse(Console.ReadLine());

            if (degree > 1)
            {
                int result = number;
                for (int i = 2; i <= degree; i++)
                {
                    result = result * number;
                }
                Console.Write($"{number} в степени {degree} равняется {result}");
            }
            else if (degree == 1)
            {
                Console.Write($"{number} в степени {degree} равняется {number}");
            }
            else if (degree == 0)
            {
                Console.Write($"{number} в степени {degree} равняется 1");
            }
            else
            {
                Console.Write($"Второе число должно быть натуральным");
            }
        }


        // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        // 452 -> 11
        // 82 -> 10
        // 9012 -> 12
        static void SumNumber()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            int digit = number;

            while (number > 0)
            {
                sum = sum + number % 10;
                number = number / 10;
            }
            Console.Write($"Сумма цифр в числе {digit} равняется {sum}");
        }


        // Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран. Пользователь вводит число элементов в массиве,
        //  минимальное, и максимальное значение. Надо заполнить массив рандомными данными от минимального до максимального значение.
        // И важное уточнение: делать все в методе который возвращает массив.
        static void ShowArray()
        {
            Console.Write("Введите число элементов массива: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Введите максиммальное значение: ");
            int max = int.Parse(Console.ReadLine());

            int[] ViewArray (int length, int min, int max)
            {
                 int[] arr = new int[length];
              
            for (int i = 0; i < length; i++)
                {
                    arr[i] = new Random().Next(min, max+1);  //max+1 потому что в условии написано "до максимального значения", а в предыдуших задачах "до" означало "включительно".
                    Console.Write($"{arr[i]}");
                }
            return arr;   
            }

            int[] array = ViewArray(length, min, max);            
        }
    }
}
