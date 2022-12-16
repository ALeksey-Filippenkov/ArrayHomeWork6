// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


//Короткий подходящий под задачу.
// void PositiveNumber (int numbeDigits) // Метод можно и возвратный сделать
// {
//     int count = 0;
//     for (int i = 0; i < numbeDigits; i++)
//     {
//         System.Console.Write($"Введите {i + 1} число: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         if (number > 0)
//             count++;
//     }
//     System.Console.WriteLine($"Вы ввели {count} положительных чисел");
// }

// System.Console.WriteLine("Введите кол-во чисел, которое хотите ввести");
// int numbeDigits = Convert.ToInt32(Console.ReadLine());
// PositiveNumber (numbeDigits);


// Решение с помощью массива
// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.Write($"Введите {i + 1} число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void SumNumber (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >0 )
//             count++;
//     }
//     System.Console.WriteLine($"Вы ввели {count} положительных чисел");
// }

// System.Console.WriteLine("Введите кол-во чисел, которое хотите ввести");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// SumNumber (array);

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double IntersectionPoint (double b1, double k1, double b2, double k2)
{
    double point = (b2-b1)/(k1-k2);
    return point;
}
System.Console.WriteLine("Программа которая находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
System.Console.Write("Введите значение для переменной k1: ");
double k1 = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите значение для переменной b1: ");
double b1 = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите значение для переменной k2: ");
double k2 = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите значение для переменной b2: ");
double b2 = Convert.ToInt32(Console.ReadLine()); 
double point = IntersectionPoint (b1, k1, b2, k2);
System.Console.WriteLine($"Координаты точки пересечения двух прямых = ({point}; {point})");
