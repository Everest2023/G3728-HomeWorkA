// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int xlen, int ylen)
{
    //Random random = new Random();
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

void Print2DArr(int[,] arr,int elem)
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


void SerchElem(int[,] arr, int elem)

{  
   bool elemFind = false;
   
   for(int i = 0; i <= arr.GetLength(0); i++)
    {  
        for(int j = 0; j <= arr.GetLength(1); j++)
        {
            if (arr[i, j] == elem)
            {
               Console.WriteLine(elem +"найден"+ i+j);
               elemFind = true;
            }
        }
    } 

if (elemFind == false)
{
     Console.WriteLine("элемент не найден");  
}
}

int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int elem = InputNum("Введите элемент для поиска: ");

//Random random = new Random();
int[,] arr = Gen2DArr(ylen, xlen);

Print2DArr(arr, elem);

SerchElem(arr, elem);

// Console.WriteLine(SerchElem);
// Console.ReadLine();

// SerchElem(
//     Gen2DArr(
//         InputNum("Введите число колонок: "),
//         InputNum("Введите искомое строк: ")
//         ), 
//             InputNum("Введите искомое число: ")
//             );

        
    