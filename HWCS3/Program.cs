using System;

namespace HWCS3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            // FindPalindrome();

            // Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            // DistanceBetweenTwoPoints3D();

            // Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            // TableOfCubes();

        }


        // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        // 14212 -> нет
        // 12821 -> да
        // 23432 -> да
        static void FindPalindrome()
        {
            System.Console.Write("Введите пятизначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 9999 && number < 100000)
            {
                if (number % 10 == number / 10000 && number / 10 % 10 == number / 1000 % 10)
                {
                    System.Console.Write($"Число {number} является палиндромом");
                }
                else
                {
                    System.Console.Write($"Число {number} НЕ является палиндромом");
                }
            }
            else
            {
                System.Console.Write("Введено некорректное число");
            }
        }

        // Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        // A (3,6,8); B (2,1,-7), -> 15.84
        // A (7,-5, 0); B (1,-1,9) -> 11.53
        static void DistanceBetweenTwoPoints3D()
        {
            Console.Write("Введите координату X первой точки ");
            int X1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y первой точки ");
            int Y1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Z первой точки ");
            int Z1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату X второй точки ");
            int X2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y второй точки ");
            int Y2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Z второй точки ");
            int Z2 = int.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));

            Console.WriteLine($"Расстояние между двумя точками равно: {distance:f2}");
        }

        // Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        // 3 -> 1, 8, 27
        // 5 -> 1, 8, 27, 64, 125
        static void TableOfCubes()
        {
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"Таблица кубов числа {number}:");

                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"{i * i * i}, ");
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное число");
            }
        }
    }
}