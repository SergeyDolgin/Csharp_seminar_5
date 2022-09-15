// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] RandomMassive(int n)
{
    double []array = new double[n];
    for (int i=0; i<n; i++)
    {
        array [i] = new Random().Next(-100, 100);
        Console.Write(array[i]+", ");
    }
    return array;
}
void DifMaxMin (int n, double [] array)
{
    double max = array [0];
    double min = array [0];
    for (int i=1; i<n; i++)
    {
        if (array [i] > max) max = array [i];
        if (array [i] < min) min = array [i];      
    }
    double dif = max - min;
    Console.WriteLine($"Difference betweem MAX and MIN elements is {dif}");
}
try
{
    System.Console.Write("Enter dimension of your massive = ");
    int n = Convert.ToInt32(Console.ReadLine());
    double [] array = RandomMassive(n); 
    DifMaxMin (n, array);
}
catch
{
    System.Console.WriteLine("You've entered not a number, or you massive is too big");
}

