// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine(" РЕШЕНО МАТИМАТИЧЕСКИМ СПОСОБОМ ");

int[,] GetMatrix(int m, int n, int min, int max) // Метод Создания двумерного массива
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // Метод печати двумерного массива
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

void MatrixProduct(int[,] firstMatrix, int[,] secondMatrix, int[,] result) // Метод произведения матриц
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                {
                    sum += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
            result[i, j] = sum;
        }
    }
}

Console.WriteLine(" Введите размер матрицы(строчки равны столбцам): ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = rows;
int[,] firstMatrix = GetMatrix(rows, columns, 0, 21);
int[,] secondMatrix = GetMatrix(rows, columns, 0, 21);
int[,] result = GetMatrix(rows, columns, 0, 21);

Console.WriteLine(" Первая матрица: ");
PrintMatrix(firstMatrix);

Console.WriteLine(" Вторая матрица:");
PrintMatrix(secondMatrix);

MatrixProduct(firstMatrix, secondMatrix, result);
Console.WriteLine(" Матрица-результат: ");
PrintMatrix(result);