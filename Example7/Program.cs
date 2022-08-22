//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

bool DayOfTheWeek(int number)
{
if (number>5 & number<8)
{
   return true; 
}
else 
{
    return false;
}
}



Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = DayOfTheWeek(number);

    if (result == true)
    {
    Console.WriteLine("Да это выходной");
    }
    else
    {
     Console.WriteLine("Это НЕвыходной");   
    }
