//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1>number2)
// {
//     Console.WriteLine("Большее число " + number1 + ", меньшее - " + number2);
// }
// else
// {
//     Console.WriteLine("Большее число " + number2 + ", меньшее - " + number1);
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// if (number1 > number2 && number1 > number3)
// {
//     Console.WriteLine("Наибольшее число это " + number1);
// }
// else if (number2 > number1 && number2 > number1)
// {
//     Console.WriteLine("Наибольшее число это " + number2);
// }
// else if (number3 > number1 && number3 > number2)
// {
//     Console.WriteLine("Наибольшее число это " + number3);
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0)
// {
//     Console.WriteLine("Это число чётное");
// }
// else
// {
//     Console.WriteLine("Это число нечётное");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Console.Write("Введите натуральное число больше, чем 1: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// if (number > 1)
// {
//     while(count <= number)
//     {
//         if(count % 2 == 0)
//         {
//             Console.Write(count + ", ");
//         }
//         count++;
//     }
// }
// else if (number == 1)
// {
//     Console.WriteLine("В ряду от 1 до 1 нет чётных чисел, ряд некорректный");
// }
// else
// {
//     Console.WriteLine("Введено неккоректное число");
// }