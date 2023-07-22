// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] numbersTable = new int[3, 4] { { 4, 2, 7, 45, }, { 5, 89, 34, 3 }, { 43, 6, 12, 3 } };

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

void SotredMatrix(int[,] martix)
{
    for (int i = 0; i < numbersTable.GetLength(0); i++)
    {
        for (int j = 0; j < numbersTable.GetLength(1); j++)
        {
            for (int k = 0; k < numbersTable.GetLength(1) - 1; k++)
            {
                if (numbersTable[i, k] < numbersTable[i, k + 1])
                {
                    int temp = numbersTable[i, k + 1];
                    numbersTable[i, k + 1] = numbersTable[i, k];
                    numbersTable[i, k] = temp;
                }

            }
        }
    }
}

PrintMatrix(numbersTable);
Console.WriteLine();
SotredMatrix(numbersTable);
PrintMatrix(numbersTable);
