// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите число");
// int numA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int numB = Convert.ToInt32(Console.ReadLine());

// void APowB()
// {
//    int result = 1;
//    for (int i = 1; i < numB+1; i++)
//    {
//         result = result * numA;
        
//    }
//    Console.WriteLine(result);
// }

// APowB();


// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12




// Console.WriteLine("Введите число");
// string num = Console.ReadLine();
// int num1 = Convert.ToInt32(num);
// int sum = 0;
// int temp = 0;

// int Sum()
// {
//      for (int i = 0; i <= num.Length; i++)
//      {
//         temp = num1%10;
//         num1 = num1/10;
//         sum = sum + temp;
//      }
//     return sum;
// }

// Sum();
// Console.WriteLine(sum); 




// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



void Array()

{
     int[] arr = new int[8];
     int count = 0;
     while (count< arr.Length)
     {
        arr[count] = Convert.ToInt32(Console.ReadLine());
        count++;
     }

    int i = 0;
    while (i<=arr.Length)
    {
        Console.Write($"{arr[i]},");
        i++;
    }
}
Array();
