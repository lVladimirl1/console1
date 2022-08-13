// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine ("Введите первое число");
int namber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int namber2 = Convert.ToInt32(Console.ReadLine());

if (namber1 > namber2)
{
    Console.Write ("Максимальное число_");
    Console.WriteLine (namber1);
    Console.Write ("Минимальное число_");
    Console.Write (namber2);
}
else if (namber1 < namber2)
{
   Console.Write ("Максимальное число_");
    Console.WriteLine (namber2);
    Console.Write ("Минимальное число_");
    Console.Write (namber1);
   
}
