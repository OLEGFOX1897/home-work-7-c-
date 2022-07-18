// homework 7 c# 16/07/2022
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Console.WriteLine();
Console.WriteLine(" Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");
Console.WriteLine("input m");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input n");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input range random numbers (0...) ");
int range=Convert.ToInt32(Console.ReadLine());
double [,] GetRandomArray(int m, int n, int range) // создает двумерный массив
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int sign= new Random().Next(-1,2); // задает +\- случайным образом
            if (sign==0) sign=1; 
            array[i,j]=new Random().NextDouble()*range*sign;
        }
    }
    return array;
}
void PrintArray(double[,] inArray) // вывводит двумерный массив
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"{inArray[row,column]:f1}  ");
        }
        Console.WriteLine();
    }
}
double [,] randomArray= GetRandomArray(m,n,range);
PrintArray(randomArray);
Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает ");
Console.WriteLine("значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine();
Console.WriteLine("Input number row array (the array was creates in the task 47)");
int row=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number column array (the array was creates in the task 47)");
int column=Convert.ToInt32(Console.ReadLine());
if (row>m | column>n | row<0 | column<0) Console.WriteLine("The array have not input element");
else if (row==m | column==n) Console.WriteLine($"Meaning array - > {randomArray[row-1,column-1]:f1}");
else  Console.WriteLine($"Meaning array - > {randomArray[row,column]:f1}");
Console.WriteLine();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. (размер берется из задачи 47)
Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Размер массива взят из задачи 47");
int [,] GetRandomArrayInt (int m, int n) // создает двумерный массив
{
    int [,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j]=new Random().Next(0,11);
        }
    }
    return array;
}
double [] arrayArithmeticMean = new double [n];
double sum=0;
int [,] arrayNew=GetRandomArrayInt(m,n);
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(arrayNew[i,j]+"  ");
    }    
    Console.WriteLine();
}

Console.WriteLine();
for (int i = 0; i < n; i++)
{
   for (int j = 0; j < m; j++)
   {
        sum=sum + arrayNew[j,i];
   } 
   arrayArithmeticMean[i]=sum/m;
   sum=0;
    Console.Write($"{arrayArithmeticMean[i]:f1}  ");
}