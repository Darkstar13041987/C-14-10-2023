// // Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// Console.WriteLine("Введите число:");
//  int number =Convert.ToInt32(Console.ReadLine()); 
// {
//     Console.WriteLine(number*number);
// }
 
Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int result = int.Parse(number);
Console.WriteLine(result*result);
