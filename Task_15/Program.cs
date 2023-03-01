// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();

int userNumber;
while (true)
{
    Console.Write("Введите порядковый номер дня недели: ");
    if (int.TryParse(Console.ReadLine(), out userNumber))
        break;
    Console.WriteLine("Ошибка ввода!");
}

if ((userNumber < 1) || (userNumber > 7))
{
    Console.WriteLine($"{userNumber} не является порядковым номером дня недели");
}
else if ((userNumber == 6) || (userNumber == 7))
{
    Console.WriteLine($"{userNumber} -> является выходным днём!");
}
else
{
    Console.WriteLine($"{userNumber} -> НЕ является выходным днём.");
}