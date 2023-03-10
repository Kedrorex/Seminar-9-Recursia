// Задача 67: Напишите программу, которая будет принимать на
//  вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int Sum(int number)
// {
//   int sum;
//   if (number > 10)
//   {
//     Sum(number /= 10);
    
//   }
// }

// Решение Мухаммада
int Sum(int value)
{
    if(value < 10)
    {
        return value % 10;
    }
    int temp = value % 10;
    value = value/10;
    return temp + Sum(value);
}

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(Sum(number));