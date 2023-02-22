//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


//1) Получение данных от пользователя
int n = ReadData("Количество строк матрицы");
int m = ReadData("Количество строк матрицы");

//2) Генерация двумерного массива
double[,] matix = FillTwoDimArray(n,m);

//3) Печатаем двумерный массив
PrintTwoDimArray(matix);


int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    double[,] outArray = new double[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.NextDouble();
            j++;
        }
        i++;
    }
    return outArray;
}


//метод для печати двумерного массива
void PrintTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
           
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor(); 
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}