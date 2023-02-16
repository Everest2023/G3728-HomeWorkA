// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)//


// вводим данные Convert.ToDouble() (преобразует к типу double)

Console.Write("Введите b1: ");
var cordinatb1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var cordinatk1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var cordinatb2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var cordinatk2 = Convert.ToDouble(Console.ReadLine());

 
 //вводи параметр  var вычисления координат точки пересечения двух прямых
var x = -(cordinatb1 - cordinatb2) / (cordinatk1 - cordinatk2);
var y = cordinatk1 * x + cordinatb1;
 
x = Math.Round(x, 3);//Функция математического округления.
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
