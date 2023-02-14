/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] MultiplicMatrix(int[,] MatrA, int[,] MatrB)
{
    if (MatrA.GetLength(1) != MatrB.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить");
    int[,] MatrC = new int[MatrA.GetLength(0), MatrB.GetLength(1)];
    for (int i = 0; i < MatrA.GetLength(0); i++)
    {
        for (int j = 0; j < MatrB.GetLength(1); j++)
        {
            for (int k = 0; k < MatrB.GetLength(0); k++)
            {
                MatrC[i, j] += MatrA[i, k] * MatrB[k, j];
            }
        }
    }
    return MatrC;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] GenerateMatrix(string text)
{
    Console.WriteLine($"Введите размерность матрицы {text}: ");
    int[,] result = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"{text}[{i},{j}] = ");
            result[i, j] = Convert.ToInt32(Console.ReadLine());
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
//int row = GetNumFromUser("Введите число сторк: ");
//int column = GetNumFromUser("Введите число столбцов: ");

// Генерация 2х мерного массива размером м и н
int[,] realArrayA = GenerateMatrix("A");
int[,] realArrayB = GenerateMatrix("B");

// Выводим массивы
Console.WriteLine("\nМатрица A:");
ShowMatrix(realArrayA);
Console.WriteLine("\nМатрица B:");
ShowMatrix(realArrayB);

//Умножаем матрицы
int[,] realArrayC = MultiplicMatrix(realArrayA, realArrayB);

// Выводим результат умножения матриц
Console.WriteLine("\nМатрица C:");
ShowMatrix(realArrayC);

