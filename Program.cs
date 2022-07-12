//Task 25: Напишите цикл, который принимает на вход два числа (A и B) и
// /// возводит число A в натуральную степень B.
// Console.WriteLine("Input A= ");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B= ");
// int b=Convert.ToInt32(Console.ReadLine());
// int mathAB=1;
// for (int i = 0; i < b; i++)
// {
//     mathAB=mathAB*a;    
// }
// Console.WriteLine($"{a}^{b} - > {mathAB}");

// // Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Input Number= ");
// int number=Convert.ToInt32(Console.ReadLine());
// int i=1;
// int j=0;
//     while (number>i) // цикл определения размера числа
//     {
//         i=i*10;
//         j++;
//     }

// int digitNum = 0; // цифра в числе
// int ind = 1; // индекс для движения по числу
// int sumDigit=0; // сумма цифр числа
// for (i = 0; i < j; i++)
// {
//     digitNum=number/ind%10;
//     ind=ind*10;
//     sumDigit =sumDigit +digitNum;
// }
//  Console.WriteLine($"the sum of the digits  = {sumDigit}");

// task 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int range=new Random().Next(1,8); // определяет размер массива от 1...8
// int [] array= new int [range]; 
// for (int i = 0; i < range; i++)
// {
//     array[i]=new Random().Next(1,100);
// }
// for (int i = 0; i < range; i++)
// {
//     Console.Write(array[i]+" ");
// }
