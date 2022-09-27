// ===============================================================
// #№50 Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
// ===============================================================

//создаётся рандомный двумерный массив с заданными пользователем границами
int[,] Fill2DArray(int rows, int columns, int arrMin, int arrMax)
{
    Random rnd = new Random();
    int[,] array2D = new int[rows, columns];
    if (arrMin < arrMax)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array2D[i, j] = rnd.Next(arrMin, arrMax + 1);
            }
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
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int FindElem(int x, int y, int[,] array)
{
    if (x < array.GetLength(0) && y < array.GetLength(1)) return array[x-1, y-1];
    else return -1;
}

//чтение данных пользователя
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int[,] arr2D = Fill2DArray(5, 5, 1, 100);
Print2DArray(arr2D);
int x = ReadData("Введите строку элемента: ");
int y = ReadData("Введите столбец элемента: ");
int findElm = FindElem(x,y,arr2D);
PrintResult("Значение на позиции элемента: " + findElm);
