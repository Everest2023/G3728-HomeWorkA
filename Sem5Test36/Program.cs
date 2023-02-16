// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// метод вывода данных
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
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

// метод считает сумму нечетных элементов
int SumPos(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i = i+2)
    {
            res+= arr[i];
    }
    return res;
}

// задаем  ограничения массива для регенерации рандома
int[] testArr = Gen1DArr(5, -9, 100);

Print1DArr(testArr);

int res = SumPos(testArr);

PrintData("Cумму элементов, стоящих на нечётных позициях: ", res);




