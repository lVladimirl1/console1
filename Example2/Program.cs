//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.WriteLine ("Введите первое число");
int namber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int namber2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите третье число");
int namber3 = Convert.ToInt32(Console.ReadLine());

int max = namber1;

if (namber1 < namber2) max = namber2;
if (namber2 < namber3) max = namber3;
if (namber3 < namber1) max = namber1;
 
 Console.Write ("Максимальное число_");
 Console.WriteLine (max);


