void FillArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,10);
    }
}

void Print(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}



void Task34()
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.

    int size = 12;
    int [] numbers = new int[size];

    FillArray(numbers);
    Print(numbers);    

    int counter = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 == 0)
        {
            counter++;
        }

    }
    Console.WriteLine($"количество четных чисел: {counter}");

}


void Task36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

    int size = 12;
    int [] numbers = new int[size];
    FillArray(numbers);
    Console.WriteLine("Вот наш массив: ");
    Print(numbers);
    int sum = 0;

    for (int i = 0; i < numbers.Length; i+=2)
    sum = sum + numbers[i];

    Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");

}



Task36();
