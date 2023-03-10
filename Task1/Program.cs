// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


void RoadTon(int N)
{
  if(N==0)
  {
    return;
  }
  RoadTon(N-1);
  Console.Write($"{N} ");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadTon(number);