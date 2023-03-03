// Задайте массив вещественных чисел. Найдите разницу между минимальным и максимальным элементами массива

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

// Метод поиска минимального элемента в массиве

int MinNumber (int [] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length-1; i++)
        {
            if (min > array[i])
            min = array[i]; 
        }
    return (min);
}
// Метод поиска максимального элемента в массиве

int MaxNumber (int [] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length-1; i++)
        {
            if (max < array[i])
            max = array[i]; 
        }
    return (max);
}

// Метод, который ничего не вернет, но выведет результат
void PrintData (string message)
 {
     Console.WriteLine (message);
 }

// Обращение к методу ввода
int Length = ReadData ("Enter Lenght massiv: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");

// Вывод сгенерированного массива
int []arr = Gen1DArray(Length,min,max);
Print1DArray (arr);

// Вывод результата поиска
int ResMin = MinNumber (arr);
PrintData ("Min number = "+ResMin);
int ResMax = MaxNumber (arr);
PrintData ("Max number = "+ResMax);
int resalt = ResMax-ResMin;
PrintData ("The difference between the maximum and minimum number = "+resalt);

// Время, затраченное на метод 
Console.Write ("Elapsed time = ");
DateTime d1 = DateTime.Now;
Console.WriteLine (DateTime.Now - d1);

