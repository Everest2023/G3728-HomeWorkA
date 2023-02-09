// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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
int Pow(int numa, int numb)
{
    int result = 1;
    while(numb>0)
    {
    numb=numb-1;
    result = result*numa;
    }
    return result;
}
// Ввод данных
int numa= ReadData("Введите N1: ");
int numb = ReadData("Введите N2: ");

int result = Pow(numa,numb);

PrintData("Число: ",  result);