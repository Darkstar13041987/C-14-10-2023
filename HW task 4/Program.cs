// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
if
(a>b || a>c)
{
    Console.WriteLine($" {a} это максимальное число");
}
else if

  (b>a || b>c)  
{
Console.WriteLine($" {b} это максимальное число");
}
else if
(c>a || c>b)
{
    Console.WriteLine($" {c} это максимальное число");
}

else
 {
 Console.WriteLine("Числа равны");
 }