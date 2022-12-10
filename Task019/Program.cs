// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите, пожалуйста, пятизначное число: ");
string? input = Console.ReadLine();
 bool result = int.TryParse(input, out var number);
if (result == true)
{
  string palindrome = Convert.ToString(number);
  {
    if (palindrome.Length > 5) Console.WriteLine("Введенное число не является пятизначным.");
    else
    {
        if (palindrome[0] == palindrome[4] && palindrome[1] == palindrome[3])
        {
            Console.WriteLine("Введенное пятизначное число является палиндромом");
        }
         
        
        else Console.WriteLine("Введенное число не является палиндромом");
    }
  }


}
  
else
    Console.WriteLine("Введенные данные не являются числом");