// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// метод вывода данных
// void PrintData(string msg1, double msg2)
// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }

//метод генерирует массив
double[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble();//+ new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
// метод печатает массив
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}

// метод считает сумму нечетных элементов
double MinMax(double[] arr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];    
    }
    return(max-min);
}


// задаем  ограничения массива для регенерации рандома
double[] testArr = Gen1DArr(5, 2, 100);

Print1DArr(testArr);

double res = MinMax(testArr);

Console.WriteLine (res);

