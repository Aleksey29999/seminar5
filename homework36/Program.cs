// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray (int arraySize)
{
int[] array = new int[arraySize];
Random rnd = new Random();
for (int i =0; i<array.Length; i++)
array[i] = rnd.Next(-100, 100);
return array;
}
Console.WriteLine("введите колличество элементов массива");
int arraySize = int.Parse(Console.ReadLine());
int[] array = CreateArray (arraySize);
Console.WriteLine(string.Join(",", array));

int EvenNumbers (int[] array, int arraySize)
{
    int i =1;
    int Numbers = 0;
for ( i=1; i<arraySize; i=i+2) 
{
     Numbers = Numbers + array[i];
    }
return Numbers;
}
int number = EvenNumbers (array, arraySize);
 Console.WriteLine(number);
 