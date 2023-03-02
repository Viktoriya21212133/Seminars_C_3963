// Напишите программу, которая принимает на вход пятизначное значениек и проверяет является ли оно палиндромом 
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

// Пишем словарь
Dictionary <int, string> palindrome = new Dictionary <int, string>();
//1001, 1111, 1221, 1331, 1441, 1551, 1661, 1771, 1881, 1991

palindrome.Add (1001, "This number is palindrome"); palindrome.Add (2002, "This number is palindrome"); palindrome.Add (3003, "This number is palindrome");
palindrome.Add (4004, "This number is palindrome"); palindrome.Add (5005, "This number is palindrome"); palindrome.Add (6006, "This number is palindrome");
palindrome.Add (7007, "This number is palindrome"); palindrome.Add (8008, "This number is palindrome"); palindrome.Add (9009, "This number is palindrome");

palindrome.Add (1111, "This number is palindrome"); palindrome.Add (2112, "This number is palindrome"); palindrome.Add (3113, "This number is palindrome");
palindrome.Add (4114, "This number is palindrome"); palindrome.Add (5115, "This number is palindrome"); palindrome.Add (6116, "This number is palindrome");
palindrome.Add (7117, "This number is palindrome"); palindrome.Add (8118, "This number is palindrome"); palindrome.Add (9119, "This number is palindrome");

palindrome.Add (1221, "This number is palindrome"); palindrome.Add (2222, "This number is palindrome"); palindrome.Add (3223, "This number is palindrome");
palindrome.Add (4224, "This number is palindrome"); palindrome.Add (5225, "This number is palindrome"); palindrome.Add (6226, "This number is palindrome");
palindrome.Add (7227, "This number is palindrome"); palindrome.Add (8228, "This number is palindrome"); palindrome.Add (9229, "This number is palindrome");

palindrome.Add (1331, "This number is palindrome"); palindrome.Add (2332, "This number is palindrome"); palindrome.Add (3333, "This number is palindrome");
palindrome.Add (4334, "This number is palindrome"); palindrome.Add (5335, "This number is palindrome"); palindrome.Add (6336, "This number is palindrome");
palindrome.Add (7337, "This number is palindrome"); palindrome.Add (8338, "This number is palindrome"); palindrome.Add (9339, "This number is palindrome");

palindrome.Add (1441, "This number is palindrome"); palindrome.Add (2442, "This number is palindrome"); palindrome.Add (3443, "This number is palindrome");
palindrome.Add (4444, "This number is palindrome"); palindrome.Add (5445, "This number is palindrome"); palindrome.Add (6446, "This number is palindrome");
palindrome.Add (7447, "This number is palindrome"); palindrome.Add (8448, "This number is palindrome"); palindrome.Add (9449, "This number is palindrome");

palindrome.Add (1551, "This number is palindrome"); palindrome.Add (2552, "This number is palindrome"); palindrome.Add (3553, "This number is palindrome");
palindrome.Add (4554, "This number is palindrome"); palindrome.Add (5555, "This number is palindrome"); palindrome.Add (6556, "This number is palindrome");
palindrome.Add (7557, "This number is palindrome"); palindrome.Add (8558, "This number is palindrome"); palindrome.Add (9559, "This number is palindrome");

palindrome.Add (1661, "This number is palindrome"); palindrome.Add (2662, "This number is palindrome"); palindrome.Add (3663, "This number is palindrome");
palindrome.Add (4664, "This number is palindrome"); palindrome.Add (5665, "This number is palindrome"); palindrome.Add (6666, "This number is palindrome");
palindrome.Add (7667, "This number is palindrome"); palindrome.Add (8668, "This number is palindrome"); palindrome.Add (1969, "This number is palindrome");

palindrome.Add (1771, "This number is palindrome"); palindrome.Add (2772, "This number is palindrome"); palindrome.Add (3773, "This number is palindrome");
palindrome.Add (4774, "This number is palindrome"); palindrome.Add (5775, "This number is palindrome"); palindrome.Add (6776, "This number is palindrome");
palindrome.Add (7777, "This number is palindrome"); palindrome.Add (8778, "This number is palindrome"); palindrome.Add (9779, "This number is palindrome");

palindrome.Add (1881, "This number is palindrome"); palindrome.Add (2882, "This number is palindrome"); palindrome.Add (3883, "This number is palindrome");
palindrome.Add (4884, "This number is palindrome"); palindrome.Add (5885, "This number is palindrome"); palindrome.Add (6886, "This number is palindrome");
palindrome.Add (7887, "This number is palindrome"); palindrome.Add (8888, "This number is palindrome"); palindrome.Add (9889, "This number is palindrome");

palindrome.Add (1991, "This number is palindrome"); palindrome.Add (2992, "This number is palindrome"); palindrome.Add (3993, "This number is palindrome");
palindrome.Add (4994, "This number is palindrome"); palindrome.Add (5995, "This number is palindrome"); palindrome.Add (6996, "This number is palindrome");
palindrome.Add (7997, "This number is palindrome"); palindrome.Add (8998, "This number is palindrome"); palindrome.Add (9999, "This number is palindrome");

// Приглашение на ввода числа и сразу его парсим 
Console.WriteLine ("Inter number: ");
int Num = int.Parse(Console.ReadLine()??"0"); 

 // Проверяем есть ли значение числа в словаре
    if (palindrome.ContainsKey (Num))
    {
    Console.Write (palindrome[Num]);
    }
    else
    {
    Console.WriteLine ("Is not palindrome");
    }
    



