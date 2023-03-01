// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

int userNumber;
while (true)
{
    Console.Write("Введите целое число: ");
    if (int.TryParse(Console.ReadLine(), out userNumber))
        break;
    Console.WriteLine("Ошибка ввода!");
}

int userNumberAbs = Math.Abs(userNumber);

if (userNumberAbs < 100)
{
    Console.WriteLine($"{userNumber} -> третьей цифры нет");
}
else
{
    while (userNumberAbs > 999)
    {
        userNumberAbs = userNumberAbs / 10;
    }
    int result = userNumberAbs % 10;
    
    Console.WriteLine($"{userNumber} -> {result}");
}