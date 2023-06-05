// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// _________Задача 25:____________ 
// Напишите цикл, который принимает на вход два числа 
// (A и 😎 и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральную степень");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int index = 0;
// int result = 1; 
// while (index < num2)
// {
//     result = result*num;
//     ++index;
// }
// Console.WriteLine($"{result}");
//  Console.ReadLine();


// ________Задача 27:______________
//  Напишите программу, которая принимает на вход 
//  число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = 0;
// while (num > 0)
// {
//     result = result + num%10;
//     num = num/10;
// }
// Console.WriteLine($"{result}");


// ________Задача 29:_________________ 
// Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] arr=new int[8];
// int index = 0;
// while (index < 8)
// {
//    Console.WriteLine("Введите число");
//    int num = Convert.ToInt32(Console.ReadLine());
//    arr[index] = num;
//    ++index;
// }
// Console.WriteLine("Вывод масcива");
// index = 0;
// while (index < 8)
// {
//    Console.WriteLine(arr[index]); 
//    ++index;  
// }