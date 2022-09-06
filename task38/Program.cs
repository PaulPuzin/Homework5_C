// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Введите размерность массива (число)");
int ElementsCount = Convert.ToInt32(Console.ReadLine());
double[] array = new double [ElementsCount];
for (int i = 0; i < array.Length; i++)
{
Console.WriteLine ("Введите число");   
array[i] = Convert.ToDouble(Console.ReadLine());
}
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (max<array[i])
    {
      max=array[i];
    }
}
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (min>array[i])
    {
        min=array[i];
    }
}
double sr = max-min;
Console.Write($"Разница между максимальным и минимальным элементом массива равна {sr}");