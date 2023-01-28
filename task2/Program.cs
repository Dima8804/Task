// Напишите программу которая будет выдавать названия дня недели по заданному номеру

Console.Clear();
Console.Write("put number: ");
int number = int.Parse(Console.ReadLine());

if(number == 1)
{
    Console.WriteLine(" Monday");
}
if(number == 2)
{
    Console.WriteLine(" Tuesday ");
}
if(number == 3)
{
    Console.WriteLine("Wensday ");
}
if(number == 4)
{
    Console.WriteLine("Thursday ");
}
if(number == 5)
{
    Console.WriteLine("Friday ");
}
if(number == 6)
{
    Console.WriteLine("Saturday ");
}
if(number == 7)
{
    Console.WriteLine("Sanday ");
}
if(number > 7)
{
    Console.WriteLine(" not  ");
}