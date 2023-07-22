// Задача 56. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumLineElements(int[,] matrix, int i) // Метод поиска суммы каждого ряда
{
    int sumLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i, j];
    }
    return sumLine;
}

PrintMatrix(numbersTable);

int minSumLine = 0;
int sumLine = SumLineElements(numbersTable, 0);
for (int i = 1; i < numbersTable.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(numbersTable, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
