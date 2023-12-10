//Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет количество чётных чисел в массиве.

int[] arr = new int[10];

int dig = 0;

for (int i = 0; i < arr.Length; i++)
{
  arr[i] = new Random().Next(1, 101);
  System.Console.Write(arr[i] + " ");

  if (arr[i] % 2 == 0)
  {
    dig++;
  }

}
Console.WriteLine();
Console.WriteLine(dig + " четных элемента(ов)");





