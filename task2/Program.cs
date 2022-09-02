// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    string readValue = Console.ReadLine(); //считывает с консоли строку
    int result = int.Parse(readValue); // преобразует строку в целое число
    return result; //возвращает результат
}
int[,] FillArray(int numLines, int numColumns)
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

void PrintArray(int[,] matrix)
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
void MinSumRow(int[,] matrix)
{
    int min = 0;
    int k = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum = sum + matrix[j, i];
        }

        if (sum < min || min == 0)
        {
            min = sum;
            k = j;
        }
        
    }
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов : строка {k + 1}\t");
}

int[,] array = FillArray(
    Prompt("Введите количество строк массива : "),
    Prompt("Введите количество столбцов массива : ")
);
PrintArray(array);
System.Console.WriteLine();
MinSumRow(array);
Console.WriteLine();
