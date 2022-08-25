// Необязательная задача про подсчет программистов.
  Console.WriteLine("Введите число программистов в комнате:");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    Console.WriteLine("Людей с минусом посчитать нельзя");
}
else if (N == 0)
{
    Console.WriteLine("В комнате нет программистов");
}
else if (N % 100 == 11 || N % 100 == 12 || N % 100 == 13 || N % 100 == 14)
{
    Console.WriteLine("В комнате " + N + " программистов");
}
else if (N % 10 == 1)
{
    Console.WriteLine("В комнате " + N + " программист");
}
else if (N % 10 == 2 || N % 10 == 3 || N % 10 == 4)
{
    Console.WriteLine("В комнате " + N + " программиста");
}
else
{

    Console.WriteLine("В комнате " + N + " программистов");

}
