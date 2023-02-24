// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j+i;
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i <= arr.GetLength(0); i++)
    {
        for (int j = 0; j <= arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

void Print1DArr(int[] MeanColom)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}


int[] MeanColom(int[,] arr)

{  
   int [means] = new int[GetLength(0)];
   for(int i = 0; i <= arr.GetLength(1); i++)
    {  
        for(int j = 0; j <= arr.GetLength(0); j++)
        {
            means[i]+= arr[j,i];
        }
        means[i] = means[i]/arr.GetLength(0);
    } 
    return means;
}



int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");


int[,] arr = Gen2DArr(5, 7, 1, 6);

Print1DArr(MeanColom);


Print2DArr(arr);
Console.WriteLine("Ср. арефм из главной " + MeanColom(arr, true));
Console.WriteLine("Ср. арефм из побочной  " + MeanColom(arr, false));