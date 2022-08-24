// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите целое число");
int NumberAll = Convert.ToInt32(Console.ReadLine());
if ((99 / NumberAll) >= 1)
{
    Console.WriteLine("В данном числе нет третьей цифры");
}
else
{
    string number = NumberAll.ToString();
    int three = int.Parse(number[2].ToString());
    Console.Write("Третья цифра введенного числа: " + three);
}