// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

double[] CreateArray (int arraySize)
{
double[] array = new double[arraySize];
Random rnd = new Random();
for (int i =0; i<array.Length; i++)
array[i] = rnd.Next(100, 1000);
return array;
}
Console.WriteLine("введите колличество элементов массива");
int arraySize = int.Parse(Console.ReadLine());
double[] array = CreateArray (arraySize);
Console.WriteLine(string.Join(",", array));

double EvenNumbers (double[] array, int arraySize)
{
    int i =0;
    int Numbers = 0;
for ( i=0; i<arraySize; i++) 
{
     if (array[i] % 2 == 0)
     Numbers +=1;
}
return Numbers;
}
double number = EvenNumbers (array, arraySize);
 Console.WriteLine(number);
 