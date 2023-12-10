//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// Console.WriteLine("Введите размер массива");
// int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[10];
int dig = 0;

for (int i = 0; i < arr.Length; i++)
{
  arr[i] = new Random().Next(1, 101);
  System.Console.Write(arr[i] + " ");
  if (arr[i] >= 20 && arr[i] <= 90)
  {
    dig++;
  }
}
Console.WriteLine();





Console.WriteLine(dig + " элементов массива, значения которых лежат в отрезке [20,90]");
