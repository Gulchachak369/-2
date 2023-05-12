// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0 && number < 6)
{
    Console.Write("Нет");
}
else if (number == 6)
{
    Console.Write("Да");
}
else if (number == 7)
{
    Console.Write("Да");
}
else 
{
    Console.Write("такого дня недели не существует");
}
