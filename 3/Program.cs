//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("ВВедите количесвто элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[num];



for (int i = 0; i < arr.Length; i++)
{
  arr[i] = new Random().NextDouble() * 20;
  System.Console.Write(arr[i] + " ");

  Console.WriteLine();  //разделитель в консольном выводе
  Console.WriteLine(arr);

}
double max = double.MinValue;
double min = double.MaxValue;
for (int i = 0; i < arr.Length; i++)  // проходимся по массиву в поиске мак и мин
{
  if (arr[i] > max)
  {
    max = arr[i];
  }
}
for (int i = 0; i < arr.Length; i++)
{
  if (arr[i] < min)
  {
    min = arr[i];
  }
}
double diff = max - min;
Console.WriteLine(diff + " - разница между максимальным и минимальным элементом массива");
