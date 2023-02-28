//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

int userNumber;
while (true)
{
    Console.Write("Введите целое трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out userNumber))
        break;
    Console.WriteLine("Ошибка ввода!");
}

int result = userNumber / 10 % 10;

Console.WriteLine($"{userNumber} -> {result}");
