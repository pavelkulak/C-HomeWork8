// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18






int rowsA = GetNum("Введите количество строк первой матрицы: ");
int columnsA = GetNum("Введите количество столбцов первой матрицы: ");
int[,] matrixA = GetRandomMatrix(rowsA, columnsA);

int rowsB = GetNum("Введите количество строк второй матрицы: ");
int columnsB = GetNum("Введите количество столбцов второй матрицы: ");
int[,] matrixB = GetRandomMatrix(rowsB, columnsB);

PrintMatrix(matrixA, "Матрица A:");
PrintMatrix(matrixB, "Матрица B:");

int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);
PrintMatrix(resultMatrix, "Результирующая матрица:");


int GetNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(1, 10); // Генерируем случайное значение от 1 до 9
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string message)
{
    Console.WriteLine(message);
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsA = matrixA.GetLength(1);
    int columnsB = matrixB.GetLength(1);

    int[,] resultMatrix = new int[rowsA, columnsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columnsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < columnsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}
