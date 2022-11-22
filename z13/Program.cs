//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5


// решение задачи текстом.
// Console.WriteLine("Введите трехзначное число");
// string text = Console.ReadLine();

// //создаём условие:  если переменная text.Length количество символов больше 2 по массиву строки,то
// if (text.Length > 2)
// { //то консоль выводит на экран текст "третья цифра -> и обращается ко второму элементу массива и пишет его значение"
//     Console.WriteLine("третья цифра -> " + text[2]);
// }
// else
//  { //иначе если значение переменной text.Length меньше двух, то коносль выводит текст "третьей цифры нет"
//     Console.WriteLine("-> третьей цифры нет");
// }


double input_number, number;

Console.WriteLine("Введите трёхзначное число");
input_number = Convert.ToDouble(Console.ReadLine());
if (input_number < 1000 && input_number > 99)
{
    number = input_number / 10;   
    number = number - (int)number;  
    number = (int)(number * 10);   
    Console.WriteLine($"{input_number} -> {number}");
}
else if(input_number < 100)
{
    Console.WriteLine("нет третьей цифры.");
}
else
{
    Console.WriteLine("не верно введено число.");
}