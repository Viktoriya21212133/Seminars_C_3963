// Напишите программу, которая заполнит спирально массив 4 на 4 

// Введем размерность массива и сам массив
int n = 4;
int[,] array = new int[n, n];

// Объявляем переменные, иначе нет возможности работать в массиве
int buf = 1;
int i = 0;
int j = 0;

// цикл заполнения массива
while (buf <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = buf;
  buf++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

// Метод печати массива
void PrintArray (int[,] arraySpiral)
{
  for (int i = 0; i < arraySpiral.GetLength(0); i++)
  {
    for (int j = 0; j < arraySpiral.GetLength(1); j++)
    {
      if (arraySpiral[i,j] / 10 <= 0)
      Console.Write($" {arraySpiral[i,j]} ");

      else Console.Write($"{arraySpiral[i,j]} ");
    }
    Console.WriteLine();
  }
}

// Печатаем массив
PrintArray(array);
