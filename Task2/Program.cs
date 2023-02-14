/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/

int[] SummMatrixInRow(int[,] matrix)
{

    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int[] summRow = new int[row];

    for (int i = 0; i < row; i++)
    {
        int summa = 0;
        for (int j = 0; j < col; j++)
        {
            summa += matrix[i, j];
        }
        summRow[i] = summa;
    }
    return summRow;
}

void ShowMatrix(int[] matrix)
{
    int min = matrix[0];
    int rowMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (min > matrix[i])
        {
            min = matrix[i];
            rowMin = i;
        }
    }
    Console.WriteLine($"В {rowMin + 1} строке сумма элементов минимальна min = {min}");
}

void ShowMatrixBivariate(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[,] GenerateMatrix(int rows, int columns, int to)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(0, to);
        }
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
int row = GetNumFromUser("Введите число сторк: ");
int column = GetNumFromUser("Введите число столбцов: ");

// Генерация 2х мерного массива размером м и н
int[,] realArray = GenerateMatrix(row, column, 10);

// Выводим массив
ShowMatrixBivariate(realArray);

//Сортируем массив
int[] summRow = SummMatrixInRow(realArray);

//выводим результат
ShowMatrix(summRow);
