// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InNumber(string numberName)
{
    System.Console.WriteLine($"Введите число{numberName}");
    int num = int.Parse(Console.ReadLine());
    return num;
}
int Construction(int numA, int numB)
{
    int result = numA;
    for (int i = 2; i <= numB; i++)
    {
        result = result*numA;
    }
    return result;
}

int numA  = InNumber(" A :");
int numB  = InNumber(" B :");
System.Console.WriteLine($"Число {numA} в степени {numB} = {Construction(numA, numB)}");