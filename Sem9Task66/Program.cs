// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// суммирование от m до n с использованием рекурсии
int RecLineMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
    {
        return m + RecLineMN(m + 1, n);
    }
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");

int res = numM<numN? RecLineMN(numM,numN):RecLineMN(numN,numM);
Console.WriteLine(res);
