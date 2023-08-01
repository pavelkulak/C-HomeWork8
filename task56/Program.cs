// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int row = GetNum("Введите количество строк: ");
int column = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(row, column);
int minRowSum = int.MaxValue;
int minRowIndex = -1;
PrintArray(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = CalculateRowSum(array, i);
    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        minRowIndex = i;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1} строка");


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
int CalculateRowSum(int[,] arr, int rowIndex)
{
    int sum = 0;
    int columns = arr.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
        sum += arr[rowIndex, j];
    }
    return sum;
}