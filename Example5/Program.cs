//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
string result = number.ToString();
int i = 1;

void SecondDigitNumber()
{
if(number > 99 & number < 999)
{
    Console.Write(result[i]);
    Console.Write("-Вторая цифра числа");
}
else
{
    Console.WriteLine("Это не трёхзначное число");
}
}
SecondDigitNumber();
