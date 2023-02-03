// №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22
// Ввод чисел пользователем:
//Считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
//Считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();
//Считываем данные с консоли 23 число
string? inputNum3 = Console.ReadLine();

//проверяем на пустоту
if ((inputNum1 != null) && (inputNum2 != null) && (inputNum3 != null))
{
//Парсим введенное число
  int number1 = int.Parse(inputNum1);
  int number2 = int.Parse(inputNum2);
  int number3 = int.Parse(inputNum3);

  if (number1 > number2)
  {
    if (number1 > number3)
    {
        Console.WriteLine("max: " + number1);
    }
    else
    {
        Console.WriteLine("max: " + number3);
    }
  }


  else 
  if (number2 > number3)
  {
    Console.WriteLine("max: " + number2);
  }

  else
    {
        Console.WriteLine("max: " + number3);
    }

}