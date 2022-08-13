// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).


Console.Clear();

Console.WriteLine ("Введите число");
int namber = Convert.ToInt32(Console.ReadLine());



if (namber % 2 == 1)
{
    Console.WriteLine (namber);
    Console.WriteLine ("Нечетное число");
}
else 
{
    Console.WriteLine (namber);
    Console.WriteLine ("Четное число");
}









