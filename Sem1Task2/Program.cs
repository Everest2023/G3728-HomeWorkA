// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// считываем данные с консоли 2 числа
string? inputNumA = Console.ReadLine();
string? inputNumB = Console.ReadLine();

// проверяем не пустые ли данные
if ((inputNumA != null) && (inputNumB != null))
{
    //парсим введеные числа
    int numberA = int.Parse(inputNumA);
    int numberB = int.Parse(inputNumB);

    // проверяем  что больше
    if (numberA > numberB)
    {
        // выводим значение
       Console.WriteLine("число 1 больше 2");
       
       // Как вывести число?
       //Console.WriteLine("max: "+ numberA);
    }
    else
    {
       Console.WriteLine("число 2 больше 1");
       //Console.WriteLine("max: "+ numberB);
    }
}

