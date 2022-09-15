// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] RandomMassive(int n)
{
    int []array = new int[n];
    for (int i=0; i<n; i++)
    {
        array [i] = new Random().Next(-100, 100);
        Console.Write(array[i]+", ");
    }
    return array;
}
void OddPositions (int n, int [] array)
{
    int sum = 0;
    int position = 0; 

    for (int i=0; i<n; i++)
    {
        position = i%2;
        if (position == 1) sum = sum+array[i];
    }
    Console.WriteLine($"Sum of elements on ODD POSOTIONS is {sum}");
}
try
{
    System.Console.Write("Enter dimension of your massive = ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] array = RandomMassive(n); 
    OddPositions (n, array);
}
catch
{
    System.Console.WriteLine("You've entered not a number, or you massive is too big");
}

