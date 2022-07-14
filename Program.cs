// homework seminar 5 c#
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
// 345, 897, 568, 234] -> 2

Console.WriteLine();
int [] CreatRandomArray (int size, int min, int max)
{
    int [] array=new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i]=new Random().Next(min,max);
    }
    return array;
}
void ShowArray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");

    }
    Console.Write("]");
}
int [] myArray34=CreatRandomArray(4,100,1000);

int quantityNumbers=0;
for (int i = 0 ; i < myArray34.Length ; i++)
{
    if (myArray34[i]%2==0) quantityNumbers=quantityNumbers+1;
}
Console.WriteLine ("Задача 34 Задайте массив заполненный случайными положительными трёхзначными числами."); 
Console.WriteLine("Напишите программу, которая покажет количество чётных чисел в массиве");
ShowArray(myArray34);
Console.Write(" -> " + quantityNumbers);
Console.WriteLine();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] myArray36=CreatRandomArray(4,-100,100);
int sumOdd=0;
for (int i = 0; i < myArray36.Length; i++)
{
    if (i%2==1) sumOdd=myArray36[i]+sumOdd;
}
Console.WriteLine();
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
ShowArray(myArray36);
Console.Write(" - > "+ sumOdd);
Console.WriteLine();
Console.WriteLine();

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("[3 7 22 2 78] -> 76");

double [] CreatRandomArrayDouble (int size, int range)
{
    double [] array=new double [size];
    for (int i = 0; i < size; i++)
    {
        array[i]=new Random().NextDouble()*range;
    }
    return array;
}
void ShowArrayDouble (double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.Write("]");
    
}
double [] myArray38=CreatRandomArrayDouble (4,10);

ShowArrayDouble (myArray38);
int minArray=0;
int maxArray=myArray38.Length-1;   
    for (int i = 0; i < myArray38.Length; i++)
    {       
        if (myArray38[minArray]>myArray38[i]) minArray=i;
        if (myArray38[maxArray]<myArray38[myArray38.Length-1-i]) maxArray=i;      
    } 
double sumMinMaxArray=myArray38[minArray]+myArray38[maxArray];
Console.Write(" - > "+sumMinMaxArray);
Console.WriteLine();
Console.WriteLine();