﻿// №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).
//  4 -> да
//  -3 -> нет
//  7 -> нет

Console.WriteLine("Введите число:");
//Считываем данные с консоли  
string? inputNum = Console.ReadLine();
//проверяем не пустые ли данные
if (inputNum != null)
{
      //парсим введеные числа
    int number = int.Parse(inputNum);
     // проверяем делится ли число
    if(number%2 == 0)
    {
       Console.WriteLine("четное");
    }

    else
    {
       Console.WriteLine("не четное"); 
    }
}

