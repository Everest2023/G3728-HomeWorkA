// №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
//Считываем данные с консоли  
string? inputNum = Console.ReadLine();
//проверяем не пустые ли данные
if (inputNum != null)
{
          //парсим введеные числа
    int number = int.Parse(inputNum);
    //вводим переменную
    string ResultNumLine = string.Empty;

     for (int i = 2; i <= number; i= i+2)
     {
        ResultNumLine = ResultNumLine + i + ", ";
     }   
     
     if(number%2 == 0)
     {
       ResultNumLine=ResultNumLine + number;
     }
     
Console.WriteLine(ResultNumLine);

}
     