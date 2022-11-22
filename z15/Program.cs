//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да


Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("выходной");
}
else if (day < 1 || day > 7)
{
    Console.WriteLine("не относится ко дню недели");
}
else
{
    Console.WriteLine("не выходной");
}
