// Задача №1.Напишите программу которая на входе принимает 2 числа и проверяет являеться ли первое число квадратом второго.
//a = 25, b = 5, yes
//a = 2, b = 10, no
//a = 9, b = -3, yes
//a = -3, b = 9, no

Console.Clear();
Console.Write("Number1: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Number2: ");
int number2 = int.Parse(Console.ReadLine());

//int sqr = number2 * number2;

if(number1 == number2*number2 )
{
    Console.Write(number1 + " Yes ");
}
else
{
    Console.Write(number1 + " No");
}