// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите порядковый номер дня недели");
int NumberDay = Convert.ToInt32(Console.ReadLine());
if (NumberDay <= 5)
{
    Console.WriteLine(NumberDay + "-й день недели НЕ является выходным");
}
else if (NumberDay > 7)
{
    Console.WriteLine("В неделе 7 дней");
}
else
{
    Console.Write(NumberDay + "-й день недели является выходным");
}