// ===============================================================
// #47 Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами. m = 3, n = 4.
// 0,5  7  -2  -0,2
// 1  -3,3  8  -9,9
// 8  7,8  -7,1  9
// * При выводе матрицы показывать каждую цифру разного цвета
// (цветов всего 16)
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
double[,] Fill2DArrDouble(int rows, int columns)
{
    Random rnd = new Random();
    double[,] array2D = new double[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array2D[i, j] = Math.Round(rnd.NextDouble() * 100, 3); //умножила на 100, чтобы числа были от 0 до 100; округлила число до тысячных)
            }
        }
    return array2D;
}

//для разноцветного окрашивания создадим массив цветов
ConsoleColor[] col = new ConsoleColor[]
             {ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
             ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
             ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
             ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
             ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
             ConsoleColor.Yellow};

//печатаем двумерный цветной  массив
void Print2DArrayColored(double[,] matr)
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

double[,] arr2D = Fill2DArrDouble(row, column);
Print2DArrayColored(arr2D);