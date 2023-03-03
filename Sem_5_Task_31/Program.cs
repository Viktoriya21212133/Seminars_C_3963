// Задайте массив из 12 элементов, заполненный случайными числами, в промежутке от -9 до 9. Найдите сумму отрицательных и положительных элементов массива.

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод печати массива 
void Print1DArray (int [] array)
{
    Console.Write ("Generated array [");
        for (int i = 0; i <array.Length-1; i++)
        {
            Console.Write (array[i] +", ");
        }
    Console.WriteLine (array[array.Length-1]+"]");
}

// Метод генерации массива с методом исключения ошибки min/max
int [] Gen1DArray (int Length, int min, int max)
{
    if (min>max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int [] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min,max+1);
    }
    return array;
}

// Метод нахождения суммы 
(int positive, int negative) NegPosSum (int [] array)
{
    int positiveSum = 0;
    int negativeSum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>0)
            {
                positiveSum+= array[i];
            }
            else
            {
                negativeSum+=array[i];
            }
        }
    return (positiveSum, negativeSum);
}

// Метод, который ничего не вернет, но выведет результат
void PrintData (string message, double res)
{
    Console.WriteLine (message+res);
}

// Обращение к методу ввода
int Length = ReadData ("Enter Lenght massiv: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");

// Вывод сгенерированного массива
int []arr = Gen1DArray(Length,min,max);
Print1DArray (arr);

// Вывод результатов
(int positive, int negative) results = NegPosSum (arr);
PrintData ("Sum of positive values = ",results.positive);
PrintData ("Sum of negative values = ",results.negative);


// Время, затраченное на метод 
Console.Write ("Elapsed time = ");
DateTime d1 = DateTime.Now;
Console.WriteLine (DateTime.Now - d1);



