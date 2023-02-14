/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,3} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] GenerateMatrix(int dim)
{
    int[,] result = new int[dim, dim];
    int i = 0;
    int j = 0;
    for (int n = 1; n <= dim * dim; n++)
    {
        if (n < dim) result[i, j++] = n;
        if (n >= dim & n < (dim * 2) - 1) result[i++, j] = n;
        if (n >= (dim * 2) - 1 & n < (dim * 3) - 2) result[i, j--] = n;
        if (n >= (dim * 3) - 2 & n < (dim * 3)) result[i--, j] = n;
        if (n >= (dim * 3) & n < (dim * 4) - 2) result[i, j++] = n;
        if (n >= (dim * 4) - 2 & n < (dim * 4) - 1) result[i++, j] = n;
        if (n >= (dim * 4) - 1 & n <= (dim * 4)) result[i, j--] = n;
    }
    return result;
}


int GetNumFromUser(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
// ввод пользователем размерности массива
int size = GetNumFromUser("Введите размер квадраиного массива: ");

// Генерация 2х мерного массива размером м и н
int[,] realArray = GenerateMatrix(size);

// Выводим массивы
ShowMatrix(realArray);