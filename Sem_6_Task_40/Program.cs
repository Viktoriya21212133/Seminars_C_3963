// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины

// Метод, который считывает данные от пользователя
int ReadData (string message)
{
    Console.Write (message);
    // Считываем число и парсим его 
    return int.Parse (Console.ReadLine()??"0");
}

// Метод, который ничего не вернет, но выведет результат
void PrintData (string message, bool res)
{
    Console.WriteLine (message+res);
}

// Метод проверки
bool TriangleTest (int A, int B, int C)
{
    bool result = false;
    if ((A<= B+C) && (B<= A+C) && (C<= A+B))
        result = true;
return result;
}

// Обращение к методу ввода
int A = ReadData ("Enter side of a triangle А: ");
int B = ReadData ("Enter side of a triangle В: ");
int C = ReadData ("Enter side of a triangle С: ");

// Обращение к методу вывода
bool resultTriangle = TriangleTest (A, B, C);
PrintData("Resalt test triangle: ", resultTriangle);