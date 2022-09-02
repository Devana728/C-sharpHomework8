// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    string readValue = Console.ReadLine(); //считывает с консоли строку
    int result = int.Parse(readValue); // преобразует строку в целое число
    return result; //возвращает результат
}
int[,] Fillmatrix(int numLines, int numColumns)
{
    int[,] matrix = new int[numLines, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 20);
        }
    }
    return matrix;
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] IncreaseElementRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            bool flagSort = true;
            for (int j = 0; j < matrix.GetLength(1) - 1 - k; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int min = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = min;
                    flagSort = false;
                }
            }
            if (flagSort)
            {
                break;
            }
        }
    }
    return matrix;
}

int[,] matrix = Fillmatrix(4, 5);
Printmatrix(matrix);
System.Console.WriteLine();
int[,] answer = IncreaseElementRow(matrix);
Printmatrix(answer);
Console.WriteLine();
