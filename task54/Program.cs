﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
int row = GetNum("Введите количество строк: ");
int column = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(row, column);
PrintArray(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    SortRowDescending(array, i);
}
Console.WriteLine("Массив после упорядочивания каждой строки по убыванию:");
PrintArray(array);
int GetNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[,] GetArray(int rows, int columns)
{
    int[,] res = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            res[i, j] = new Random().Next(1, 10);
        }
    }
    return res;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}

void SortRowDescending(int[,] arr, int rowIndex)
{
    int columns = arr.GetLength(1);
    int[] row = new int[columns];

    // Копируем элементы строки в одномерный массив
    for (int j = 0; j < columns; j++)
    {
        row[j] = arr[rowIndex, j];
    }

    // Сортируем одномерный массив по убыванию
    Array.Sort(row, (x, y) => y.CompareTo(x));

    // Копируем отсортированные элементы обратно в строку
    for (int j = 0; j < columns; j++)
    {
        arr[rowIndex, j] = row[j];
    }
}
