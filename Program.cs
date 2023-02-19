// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// int Decimal(int num)
// {
//     int sot = num / 10;
//     return  sot % 10;

// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = Decimal(num);
// Console.WriteLine(result);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// int ThirdDigit(int num)
// {
//     int result = -1;
//     if (num > 100)
//     {
//     while (num > 999)
//         {
//             num = num / 10;
//         }
//         result = num % 10;
//     }
//     else{

//     }
//     return result;
    
// }

// Console.Write("Input three-digit number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// if (ThirdDigit(number1) == -1)
// Console.WriteLine("третьей цифры нет");
// else
// Console.WriteLine($"Third digit is {ThirdDigit(number1)}");
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет




// void CheckingTheDayOfTheWeek(int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("выходной");
  
//   }
//   else Console.WriteLine("не выходной");
// }
// Console.Write("Введите цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// CheckingTheDayOfTheWeek(dayNumber);