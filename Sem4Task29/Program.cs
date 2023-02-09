// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//создаем рандомное преобразование массива
int[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end);
    }
    return arr;
}
//выводим в консоль
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}


// спрашиваем у пользователя параметры массива
int arrLen = ReadData("Введите длинну массива: ");
int begin = ReadData("Введите нижний предел значений для генерации элементов массива: ");
int end = ReadData("Введите верхний предел значений для генерации элементов массива: ");

int[] arr = Gen1DArr(arrLen, begin, end);

Print1DArr(arr);