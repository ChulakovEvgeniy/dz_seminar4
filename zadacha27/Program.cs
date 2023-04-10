// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InNumber(string numberName)
{
    System.Console.WriteLine($"Введите число{numberName}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Sum(int number)
{
    int resultat = number%10;
   while (number > 0)
   {
    number /= 10;
    resultat += number % 10;
   }
    return resultat;
}

int num = InNumber("");
System.Console.WriteLine($"Сумма всех цифр в числе {num} = {Sum(num)}");




    
