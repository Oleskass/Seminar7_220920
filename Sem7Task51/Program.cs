// ===============================================================
// #51 Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ===============================================================

int DiagSum (int[,] arr)
{
    int sum=0;
    int len = (arr.GetLength(0) < arr.GetLength(1) 
            ? arr.GetLength(0) : arr.GetLength(1)); //чтобы не выйти за границу матрицы, нам нужно найти короткую сторону матрицы и её вернуть (здесь тернарный оператор)
            for (int i = 0; i < len; i++)
            {
                sum = sum + arr[i,i]; //главная дигональ
            }
    return sum;
}

//создаётся рандомный двумерный массив с заданными пользователем границами
int[,] Fill2DArray(int countRow, int countColumn)
{
    Random rnd = new Random();
    int[,] array2D = new int[countRow, countColumn];
        for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                array2D[i, j] = rnd.Next(10, 100);
            }
        }
    return array2D;
}

//печатаем двумерный  массив
void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]}\t");
        }
        Console.WriteLine();
    }
}

//печать результата
void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}

int[,] arr = Fill2DArray(8,5);
Print2DArray(arr);
PrintResult("Сумма чисел на главной диагонали = ", DiagSum(arr));