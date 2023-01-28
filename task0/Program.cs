// Напишите программу которая на вход принимает число и выдает его квадрат(число умноженное нансамо себя)

Console.Clear(); // oshistit console
Console.Write("Put number"); // napisat v console tekst
int number = int.Parse(Console.ReadLine()); // Что бы взять с концоля числа
int sqr = number*number;
Console.WriteLine("number "  + number + " qvals = " + sqr);