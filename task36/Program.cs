// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).

Console.WriteLine("Введите размерность массива (число)");
int ElementsCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int [ElementsCount];
Random r = new Random();
for (int i=0;i<array.Length;i++)
{
array[i]=r.Next(-10000,10000); // поставил ограничитель для удобства
Console.WriteLine(array[i] + " ");
}
int sum = 0;
for (int i=0;i<array.Length;i++)
{
    if (i%2!=0)
    { 
        sum=sum+array[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");