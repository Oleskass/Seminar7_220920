// ===============================================================
// #48 Задайте двумерный массив размера m на n, каждый элемент 
// в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный 
// массив на экран. Пример: m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// ===============================================================

//создаём двумерный массив, который заполняется суммами индексов строк и столбцов
int[,] Fill2DArrSum(int rows, int columns)
{
    Random rnd = new Random();
    int[,] array2D = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array2D[i, j] = i + j;
            }
        }
    return array2D;
}

//печатаем двумерный  массив
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Print2DArray(Fill2DArrSum(5, 5));