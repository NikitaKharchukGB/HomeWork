using System;

namespace HWCS2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            // SecondNumber();

            // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            //FindThirdNumber();

            // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            // DayOff();

            //Доп.Задача. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
            //Multiplicity();
        }

        // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        // 456 -> 5
        // 782 -> 8
        // 918 -> 1
        static void SecondNumber()
        {
            System.Console.Write("Введите трёхзначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 100 & number < 1000)
            {
                int second = (number / 10) % 10;
                System.Console.WriteLine($"Вторая цифра числа {number} - это {second}");
            }
            else
            {
                System.Console.WriteLine("Необходимо ввести именно трёхзначное число");
            }
        }


        // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        // 645 -> 5
        // 78 -> третьей цифры нет
        // 32679 -> 6
        static void FindThirdNumber()
        {
            System.Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int[] array = number.ToString().ToCharArray().Select(x => x - '0').ToArray();

            int index = 0;

            if (number > 99)
            {
                index = array[2];
                System.Console.WriteLine($"Третья цифра числа {number} - это {index}");
            }
            else
            {
                System.Console.WriteLine($"Число {number} не содержит третьей цифры");
            }

        }

        // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        // 6 -> да
        // 7 -> да
        // 1 -> нет
        static void DayOff()
        {
            System.Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1: Console.WriteLine("Будний день"); break;

                case 2: Console.WriteLine("Будний день"); break;

                case 3: Console.WriteLine("Будний день"); break;

                case 4: Console.WriteLine("Будний день"); break;

                case 5: Console.WriteLine("Будний день"); break;

                case 6: Console.WriteLine("Выходной день"); break;

                case 7: Console.WriteLine("Выходной день"); break;

                default: Console.WriteLine("Некорректное число"); break;
            }
        }

        //Доп.Задача. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
        // 14 -> нет 
        // 46 -> нет 
        // 161 -> да
        static void Multiplicity()
        {
            System.Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 7 == 0 & number % 23 == 0)
            {
                System.Console.Write($"Число {number} кратно одновременно 7 и 23");
            }
            else
            {
                System.Console.Write($"Число {number} НЕ кратно одновременно 7 и 23");
            }
        }


    }
}
