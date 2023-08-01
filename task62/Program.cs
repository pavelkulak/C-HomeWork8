// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int size = 4;
int[,] spiralArray = GenerateSpiralArray(size);
PrintArray(spiralArray);


int[,] GenerateSpiralArray(int size)
{
    int[,] arr = new int[size, size];
    int value = 1;
    int row = 0, col = 0;
    int direction = 0; // 0 - вправо, 1 - вниз, 2 - влево, 3 - вверх

    for (int i = 0; i < size * size; i++)
    {
        arr[row, col] = value;
        value++;

        switch (direction)
        {
            case 0: // вправо
                if (col + 1 >= size || arr[row, col + 1] != 0)
                {
                    direction = 1; // изменяем направление на вниз
                    row++;
                }
                else
                {
                    col++;
                }
                break;
            case 1: // вниз
                if (row + 1 >= size || arr[row + 1, col] != 0)
                {
                    direction = 2; // изменяем направление на влево
                    col--;
                }
                else
                {
                    row++;
                }
                break;
            case 2: // влево
                if (col - 1 < 0 || arr[row, col - 1] != 0)
                {
                    direction = 3; // изменяем направление на вверх
                    row--;
                }
                else
                {
                    col--;
                }
                break;
            case 3: // вверх
                if (row - 1 < 0 || arr[row - 1, col] != 0)
                {
                    direction = 0; // изменяем направление на вправо
                    col++;
                }
                else
                {
                    row--;
                }
                break;
        }
    }

    return arr;
}

void PrintArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{arr[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

