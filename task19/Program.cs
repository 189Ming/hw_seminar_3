// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99999 || number < 10000)
{
    Console.WriteLine("Введенное число не 5 значное");
    return;
}

Console.WriteLine(PalindromeCheck(number));


bool PalindromeCheck(int num)
{
    if (num / 10000 == num % 10)
    {
        int firstDigit = num / 1000 % 10;
        int secondDigit = num / 10 % 10;
        if (firstDigit == secondDigit)
        {
            Console.WriteLine("Число палиндром");
            return true;
        }
        else Console.WriteLine("число не палиндром");
        return false;
    }
    else Console.WriteLine("число не палиндром");
    return false;
}