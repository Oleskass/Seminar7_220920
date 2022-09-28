// ===============================================================
// #49 Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
// ===============================================================

//чтение данных пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
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

int[,] Update2DArrayMathPow(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i+=2) //то же что i=i+2, так как нам нужны только чётные!
    {
        for (int j = 0; j < arr2D.GetLength(1); j+=2)
        {
            arr2D[i,j] = (int)Math.Pow(arr2D[i,j], 2);
        }
    }
    return arr2D;
}

// int[,] Update2DArray(int[,] arr2D)
// {
//     for (int i = 0; i < arr2D.GetLength(0); i+=2) //то же что i=i+2, так как нам нужны только чётные!
//     {
//         for (int j = 0; j < arr2D.GetLength(1); j+=2)
//         {
//             arr2D[i,j] = arr2D[i,j] * arr2D[i,j]; //то же что arr2D[i,j] *= arr2D[i,j];
//         }
//     }
//     return arr2D;
// }

// int[,] Update2DArrayEvenIf(int[,] arr2D)
// {
//     for (int i = 0; i < arr2D.GetLength(0); i++) //то же что i=i+2, так как нам нужны только чётные!
//     {
//         for (int j = 0; j < arr2D.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//             arr2D[i,j] = arr2D[i,j] * arr2D[i,j]; //то же что arr2D[i,j] *= arr2D[i,j];
//             }
//         }
//     }
//     return arr2D;
// }

int rows = ReadData("Введите количество строк в массиве: ");
int columns = ReadData("Введите количество столбцов в массиве: ");
int[,] matrix = Fill2DArray(rows, columns);
Console.WriteLine("Созданный массив:");
Print2DArray(matrix);
Console.WriteLine("Новый массив:");
//Print2DArray(Update2DArray(matrix)); //5x5 00:00:00.0157870, 00:00:00.0158720
Print2DArray(Update2DArrayMathPow(matrix)); //5x5 00:00:00.0155250, 00:00:00.0159430
//Print2DArray(Update2DArrayEvenIf(matrix)); 5x5 00:00:00.0185350, 00:00:00.0161080, 00:00:00.0154580


// DateTime d1 = DateTime.Now;

// Console.WriteLine(DateTime.Now - d1);