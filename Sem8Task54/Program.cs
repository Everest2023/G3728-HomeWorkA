//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

// Функция сортировки элементов в строке двумерного массива, по убыванию
void Sort2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}

// void Sort2DArr(int[,] arr)
// {   int[] bufA = new int[arr.GetLength(1)];
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int i = 0; i < arr.GetLength(1); i++)
//         {
//             bufA[j] = arr[i, j];
//         }
//         Bubble1DArraySort(bufA);
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = bufA[j];
//         }
//     }
// }

//    // сортировка одномерного массива
// // 
// void BubbleSort(int[] arr)
//         {
//             int temp;
//             for (int i = 0; i < arr.Length; i++)
//             {
//                 for (int j = i + 1; j < arr.Length; j++)
//                 {
//                     if (arr[i] > arr[j])
//                     {
//                         temp = arr[i];
//                         arr[i] = arr[j];
//                         arr[j] = temp;
//                     }                   
//                 }            
//             }
//             return mas;
//         }

int[,] arr = Gen2DArr(
        InputNum("Введите количество столбцов: "),
        InputNum("Введите количество строк: ")
        );

Print2DArr(arr);
Console.WriteLine("");

Sort2DArr(arr);


Console.WriteLine("отсортированный массив:");

Print2DArr(arr);
