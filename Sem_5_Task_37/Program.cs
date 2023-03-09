// Найдите произведения пар чисел в одномерном массиве. Парой считается первый и последний элементв массива, второй и предпоследний элемент и т.д. 
// Результат записать в новый массив

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
    Console.Write ("Generated massiv[");
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

// Метод произведения элементов

int [] ConvertedArray (int [] array)
{
    int Leng = array.Length/2; 
        if (array.Length % 2 ==1)
    {
        Leng = Leng+1;
    } 
    int [] BufArr = new int [Leng];
        for (int i = 0; i < Leng; i++)
        {
            BufArr [i] = array[i] * array[Leng+1-i];
        }
return BufArr;
}

// Обращение к методу ввода
int Length = ReadData ("Enter Lenght massiv: ");
int min = ReadData ("Enter min massiv: ");
int max = ReadData ("Enter max massiv: ");


// Вывод сгенерированного массива
int []arr = Gen1DArray(Length,min,max);
Print1DArray (arr);

// Вывод получившегося массива
void PrintConvArray (int [] BufArr)
{
    Console.Write ("Resulting massiv[");
        for (int i = 0; i <BufArr.Length-1; i++)
        {
            Console.Write (BufArr[i] +", ");
        }
    Console.WriteLine (BufArr[BufArr.Length-1]+"]");
}

int [] BufArrResult = ConvertedArray(arr);
PrintConvArray (BufArrResult);

// Время, затраченное на метод 
Console.Write ("Elapsed time = ");
DateTime d1 = DateTime.Now;
Console.WriteLine (DateTime.Now - d1);


