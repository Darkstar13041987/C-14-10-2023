// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine()); 

if 
(number1 == number2*number2) 
{
Console.WtiteLine("Первое Число является квадратом второго");
}
else
{
Console.WtiteLine("Первое Число не является квадратом второго");

}


// Console.Write("Введите первое число: ");
// int x = Int32.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int y = Int32.Parse(Console.ReadLine());

// if (y * y == x){
//     Console.WriteLine("да");
// }else{
//     Console.WriteLine("нет");
// }