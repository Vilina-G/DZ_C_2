//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5

//решение задачи текстовое
//Console.WriteLine("Введите трехзначное число");
//string text = Console.ReadLine();
//Console.WriteLine(text[1]);

//решение задачи математическое

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = (int)(number / 10); // остаются первые две цыфры трёхзначного числа 
number = number % 10;   // убираем остаток и остаётся центральная цифра
Console.WriteLine(number);
