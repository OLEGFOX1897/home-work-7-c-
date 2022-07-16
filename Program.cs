// home work seminar 6 c# 16/07/22
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
int ind=0; // индекс для цикла по вводу размера массива 
int ind2=0; // индекс для подсчета чисел в массиве, больших >0
int m=0;
int mArray=0; // переменная для ввода чисел в массиве
while(ind<1)
{
    Console.WriteLine("Input quantity number (M): ");
    m=Convert.ToInt32(Console.ReadLine());
    if (m<=0) 
    {
        Console.WriteLine("Reapet input"); 
        ind=0;
    }
    else ind=1;
    
}
int [] numberArray = new int [m];

for (int i = 0; i < m; i++)
{
   Console.WriteLine($"Input {i+1} number");
   mArray=Convert.ToInt32(Console.ReadLine());
   numberArray[i]=mArray;
   if (mArray<0) ind2=ind2+1;
}
Console.WriteLine(); 
Console.Write("[");
for (int i = 0; i < m; i++)
{
    
    Console.Write(" "+ numberArray[i]+" ");    
}
Console.Write("] - > "+ ind2);
Console.WriteLine ();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine ("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
Console.WriteLine ("значения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine("input b1:");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k1:");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b2:");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k2:");
double k2=Convert.ToDouble(Console.ReadLine());
double xIntersection=0;
double yIntersection=0;
if (b1==b2 & k1==k2) Console.WriteLine("Прямые совпадают");
else if (k1==k2) Console.WriteLine("Прямые параллельны друг другу");
else 
{
    xIntersection =(b2-b1)/(k1-k2);
    yIntersection =k1*xIntersection+b1;
    Console.WriteLine("точка пересечения "+" ("+ xIntersection+" ;"+yIntersection+ ")");
}