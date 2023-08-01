// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




int[,,] threeDimArray = Generate3DArray(2, 2, 2);
Print3DArrayWithIndexes(threeDimArray);


int[,,] Generate3DArray(int rows, int columns, int depths)
{
    int[,,] arr = new int[rows, columns, depths];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depths; k++)
            {
                int value;
                do
                {
                    value = random.Next(10, 100);
                } while (CheckDuplicate(arr, value));
                arr[i, j, k] = value;
            }
        }
    }

    return arr;
}

bool CheckDuplicate(int[,,] arr, int value)
{
    foreach (int item in arr)
    {
        if (item == value)
        {
            return true;
        }
    }
    return false;
}

void Print3DArrayWithIndexes(int[,,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int depths = arr.GetLength(2);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depths; k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

