// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размерность массива (число)");
int ElementsCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int [ElementsCount];
Random r = new Random();
for (int i=0;i<array.Length;i++)
{
array[i]=r.Next(100,1000);
Console.Write(array[i] + " ");
}
int sum = 0;
for (int i=0;i<array.Length;i++)
{
    if (array[i]%2==0)
    {
        sum=sum+1;
    }
}
Console.WriteLine($"Количество четных элементов массива равно {sum}");