// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//* Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

Console.WriteLine("Введите пятизначное число:");
char[] digit = Console.ReadLine().ToCharArray();

// считается длинна введенного числа в массиве если 
if (digit.Length > 5)
{
    Console.WriteLine("не верно, введите 5 значьное число"); 
}

else
    if ((digit[0]==digit[4]) && (digit[1]==digit[3]))
  {
    Console.WriteLine("является полиндромом");
  }
    
  else
  {
    Console.WriteLine("не является полиндромом");
  }

// //Вариант 2
//  int num = ReadData("Введите пятизначное число:");
 
// // //Метод читает данные от пользователя
//  int ReadData(string msg) 
// { //метод считывающий целое число из консоли, выводя в неё сообщение
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
 
// //Выводим результат пользователю
// void PrintData(string msg, bool result)
// {
//      Console.WriteLine(msg + result);
// }


// bool PalinTest(int num)
// {
//     bool result = false;
//     int d1 = num/10000;
//     int d2 = (num/1000)% 10;
//     int d3 = (num/10)%10;
//     int d4 = num%10;
//     result = ((d1==d4) && (d2==d3))? true:false; 
//     return result;
// }



// PrintData("Расстояние между точками: ",  result);