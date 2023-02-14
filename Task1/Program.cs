/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


void SortMatrix(int[,] matrix)
{

    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1); 
    int temp = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int sort = 0; sort < col - 1; sort++)
            {
                if (matrix[i, sort] < matrix[i, sort+1])
                {
                    temp = matrix[i, sort + 1];                    
                    matrix[i,sort + 1] = matrix[i,sort];                    
                    matrix[i,sort] = temp;                    
                }                
            }
        }      
    }
    Console.WriteLine();
    ShowMatrix(matrix);
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
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
ShowMatrix(realArray);

//Сортируем массив и выводим результат
SortMatrix(realArray);