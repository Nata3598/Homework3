 // Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;

bool isNumber(string number)
{

   for (int i = 0; i < 5; i++)
   {
      if (!Char.IsDigit(number[i]))
      {
         return false;
      }
   }


   return true;

}


bool isPalindrome(string number)
{
   if (number[0] == number[4] && number[1] == number[3])
   {
      return true;
   }
   else
   {
      return false;
   }
}


if (number.Length == 5 && isNumber(number)) 
{
   if (isPalindrome(number) == true)
   {
      Console.WriteLine($"Число {number} - палиндром ");
   }
   else
   {
      Console.WriteLine($"Число {number} -  не палиндром ");
   }
}
else
{
   Console.WriteLine("Введите верное число");
}
