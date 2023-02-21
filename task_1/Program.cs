//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


System.Console.Write("Введите число: ");
int A =Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите степень: ");
int B =Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ответ: {Math.Pow(A,B)}");



