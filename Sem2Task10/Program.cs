﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
//Считываем данные с консоли проверяем на null и превращаем в целое 
int num = int.Parse(Console.ReadLine()??"0");
// берем сначало первые две цифры
int result = num/10;
// делением от остатка берем последнее число
result = result%10;
Console.WriteLine(result);
