// ===============================================================
// #46 Задайте двумерный массив размером m×n, заполненный 
// случайными целыми числами. Например: m = 3, n = 4.
// -1   4   8   19
//  5  -2   33  -2
// -77  3   8   1
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
int[,] Fill2DArray(int countRow, int countColumn, int arrMin, int arrMax)
{
    Random rnd = new Random();
    int[,] array2D = new int[countRow, countColumn];
    if (arrMin < arrMax)
    {
        for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                array2D[i, j] = rnd.Next(arrMin, arrMax + 1);
            }
        }
    }
    return array2D;
}

// //печатаем двумерный  массив
// void Print2DArray(int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             Console.Write($"{array2D[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// //печатаем двумерный цветной синий массив
// void Print2DArrayColoredBlue(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = ConsoleColor.Blue; //окрашиваем в синий написанное в терминале
//             Console.Write($"{matr[i, j]}\t");
//             Console.ResetColor(); //делаем цвет по умолчанию, чтобы интерфейс терминала стал снова белым
//         }
//         Console.WriteLine();
//     }
// }

//для разноцветного окрашивания создадим массив цветов
ConsoleColor[] col = new ConsoleColor[]
             {ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
             ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
             ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
             ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
             ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
             ConsoleColor.Yellow};

//печатаем двумерный цветной  массив
void Print2DArrayColored(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)]; //окрашиваем в рандомный из наших 16 цветов
            Console.Write($"{matr[i, j]}\t");
            Console.ResetColor(); //делаем цвет по умолчанию, чтобы интерфейс терминала стал снова белым
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк матрицы: ");
int column = ReadData("Введите количество столбцов матрицы: ");

int[,] arr2D = Fill2DArray(row, column, 1, 100);
//Print2DArray(arr2D);
Print2DArrayColored(arr2D);