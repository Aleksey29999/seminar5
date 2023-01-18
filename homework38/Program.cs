// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray (int arraySize)
{
int[] array = new int[arraySize];
Random rnd = new Random();
for (int i =0; i<array.Length; i++)
array[i] = rnd.Next(-10, 10);
return array;
}
Console.WriteLine("введите колличество элементов массива");
int arraySize = int.Parse(Console.ReadLine());
int[] array = CreateArray (arraySize);
Console.WriteLine(string.Join(",", array));

int EvenNumbers (int[] array, int arraySize)
{
    int i =0;
    int min =array[0];
    int max =array[0];
    int MaxMinusMin =0;
    int MaxMinNumbers = 0;
for ( i=0; i<arraySize; i=i+1) 
{
    if (max < array[i]) 
    {max =array[i];
     }
      if (min > array[i]) 
    {
        min =array[i];
     }
}
MaxMinNumbers = max-min;
return MaxMinNumbers;
}
int number = EvenNumbers (array, arraySize);
 Console.WriteLine(number);
 