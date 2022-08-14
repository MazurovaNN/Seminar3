/* Задача 19 
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи,
исключительно работа с циклами и арифметическими опреациями!!!
14212 -> нет
12821 -> да
23432 -> да
*/
int number = 0;
while (true)
{
    Console.Write("Введите пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out number))
    break;
else
    Console.WriteLine("Неверное число.");
}
int oldValue = number;
int newValue = 0;
while (number > 0)
{
    int dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
}
if (newValue == oldValue)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
Console.Write("Нажмите любую клавишу...");
Console.ReadKey();
