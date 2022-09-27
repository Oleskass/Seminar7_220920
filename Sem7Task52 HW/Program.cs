// ===============================================================
// #52 Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и 
// диагональ выделить разным цветом.
// ===============================================================

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

//печатаем двумерный массив
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

//метод вычисления среднего арифметического в столбце матрицы
double[] ArithMean(int[,] matr)
{
    double[] array = new double[matr.GetLength(1)]; //создала новый одномерный массив для вывода результата
    for (int j = 0; j < matr.GetLength(1); j++) //проходимся по столбцам
    {
        double sum = 0; //ввели переменную накопитель суммы
        for (int i = 0; i < matr.GetLength(0); i++) //цикл для строк
        {
            sum += matr[i, j]; //складываем значения разных строк в одном столбце
        }
        array[j] = sum / matr.GetLength(0); //в элемент одномерного массива кладём средние арифметические столбцов
    }
    return array;
}

//печатаем одномерный массив
void Print1DArray(double[] array)
{
    Console.Write(array[0] + ", ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

//сама программа
//создаём двумерный массив и выводим его на экран
int[,] matr = Fill2DArray(5, 5, 1, 100);
Print2DArray(matr);
//высчитываем среднее арифметическое по столбцам
double[] arithMean = ArithMean(matr);
Console.WriteLine("Среднее арифметическое каждого столбца:");
Print1DArray(arithMean);