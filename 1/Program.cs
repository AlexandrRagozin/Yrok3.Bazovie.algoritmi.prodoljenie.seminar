// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введи координату по оси oX: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси oY:");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0  && y > 0)
// {
//     Console.WriteLine("I четверть ");
// }

// else if (x < 0  && y > 0)
// {
//     Console.WriteLine("II четверть ");
// }

// else if (x < 0  && y < 0)
// {
//     Console.WriteLine("III четверть ");
// }

// else if (x > 0  && y < 0)
// {
//     Console.WriteLine("IV четверть ");
// }


// 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазан возможных координат точек в этой четверти (x и y)

// Console.Write("Введите четверть: ");

// int quarterNumber = Convert.ToInt32(Console.ReadLine()); 

// if (quarterNumber == 1) Console.WriteLine("x > 0 && y > 0");

// else if (quarterNumber == 2) Console.WriteLine("x < 0 && y > 0");

// else if (quarterNumber == 3) Console.WriteLine("x < 0 && y < 0");

// else if (quarterNumber == 4) Console.WriteLine("x > 0 && y < 0");

// else Console.WriteLine("Ошибка в введении четверти");

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите координату X1: ");

// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату y1: ");

// int y1 = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите координату x2: ");

// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату y2: ");

// int y2 = Convert.ToInt32(Console.ReadLine());

// // Math.Sqrt (Извлекает квадратный корень из числа) Math.Sqrt(25) = 5

// // Math.Pow (2, 3) => 8 = 2 * 2 * 2

// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Math.Pow(Число, степень)

// // Console.WriteLine("Расстояние между 2 точками: " + Math.Round(d, 3)); // Math.Round(Число, кол-во знаков) - сокращает все, что после запятой.


// // Console.WriteLine("" + 1); - Конкатенация: "1" + "2" = "12"
// Console.WriteLine($"Расстояние между 2 точками: {d}"); //Интерполяция

// Задача 22: Напишите программу, 
// которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1,4
//  От 1 до 3 = 1 (в квадрате), 2 (в квадрате), 3 (в квадрате)

// Console.Write("Введите число N: ");
// int finish = Convert.ToInt32(Console.ReadLine());

// int start = 1;

// while (start <= finish)
// {
//     Console.Write(Math.Pow(start,2) + " ");
//     start++;
// }

Console.Write("Введите число N: ");

int finish = Convert.ToInt32(Console.ReadLine());

for (int start = 1; start <= finish; start++)
{
    Console.Write(Math.Pow(start,2) + " ");
}