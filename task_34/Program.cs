// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int [] RandomMassive(int n)
{
    int []array = new int[n];
    for (int i=0; i<n; i++)
    {
        array [i] = new Random().Next(100, 1000);
        Console.Write(array[i]+", ");
    }
    return array;
}
void EvenNumbers (int n, int [] array)
{
    int count = 0;
    int ostatok = 1; 
    for (int i=0; i<n; i++)
    {
        ostatok = array [i]%2;
        if (ostatok == 0) count = count+1;
    }
    Console.WriteLine($"There was/were {count} EVEN NUMBERS in this massive");
}
try
{
    System.Console.Write("Enter dimension of your massive = ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] array = RandomMassive(n); 
//    System.Console.WriteLine(String.Join(",", RandomMassive(n)));
    EvenNumbers (n, array);
}
catch
{
    System.Console.WriteLine("You've entered not a number, or you massive is too big");
}