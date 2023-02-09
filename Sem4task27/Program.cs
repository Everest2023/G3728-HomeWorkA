// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}
// возводим в степень
int SumSym(int num)
{
    int result = 0;
    while(num>0)
    {
    result = result + num%10;
    num=num/10;
    }
    return result;
}
// Ввод данных
int num= ReadData("Введите число: ");


int result = SumSym(num);

PrintData("Число: ",  result);