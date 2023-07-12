// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Write("ведите число строк 1-й матрицы: ");
int firstrows = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int rowscolums = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов 2-й матрицы: ");
int secomdcolums = int.Parse(Console.ReadLine()!);

Console.Write("Введите диапазон случайных чисел: от 1 до ");
int range = int.Parse(Console.ReadLine()!);

int[,] firstArray = new int[firstrows, rowscolums];
CreateArray(firstArray);
Console.WriteLine($"\nПервая матрица: ");
PrintArray(firstArray);

int[,] secomdArray = new int[rowscolums, secomdcolums];
CreateArray(secomdArray);
Console.WriteLine($"\nВторая матрица: ");
PrintArray(secomdArray);

int[,] resultArray = new int[firstrows,secomdcolums];

MultiplyArray(firstArray, secomdArray, resultArray);
Console.WriteLine($"\nПроизведение первой и второй матриц: ");
PrintArray(resultArray);

void MultiplyArray(int[,] firstArray, int[,] secomdArray, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secomdArray[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}