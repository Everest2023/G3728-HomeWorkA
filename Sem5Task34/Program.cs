// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// метод вывода данных
void PrintData(string res)
{
    Console.WriteLine(res);
}

//метод генерирует массив
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
// метод печатает массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}

// считаем элементы массива с учетом  четности
int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

// проверяем на четность
bool Test(int n)
{
    return (n%2 == 0);
}

//задаем ограничения массива
int[] testArr = Gen1DArr(4,100,999);

Print1DArr(testArr);

int count = CountElem(testArr);

PrintData("Количество четных элементов :"+count);
