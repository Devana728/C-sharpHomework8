// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] answer = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); ++j)
        {
            answer[i, j] = 0;
            for (int k = 0; k < matrix2.GetLength(1); ++k)

                answer[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
    return answer;
}

int[,] matrix1 = Fillmatrix(4, 4);
int[,] matrix2 = Fillmatrix(4, 4);
Printmatrix(matrix1);
System.Console.WriteLine();
Printmatrix(matrix2);
System.Console.WriteLine();

int[,] answer = MatrixMultiplication(matrix1, matrix2);
Printmatrix(answer);
Console.WriteLine();
