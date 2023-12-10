// Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, 
//младший – на последнем. Размер массива должен быть равен количеству цифр.
//12345.6

Console.WriteLine("Ведите натуральное число в диапазоне от 1 до 100 000");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[6];
arr[0] = num % 10;          //1 цифра
if ((num / 10 % 10) >= 1)
{
  arr[1] = num / 10 % 10;   //2 цифра
}
else                        //повторяющиеся проверки на вывод в массиве нолей
{                           //в значениях элементолв массива в конце числа
  Array.Resize(ref arr, 1);
}

if ((num / 100 % 10) >= 1)
{
  arr[2] = num / 100 % 10;  //3 цифра
}
else
{
  Array.Resize(ref arr, 2);
}

if ((num / 1000 % 10 >= 1))  //4 цифра
{
  arr[3] = num / 1000 % 10;
}
else
{
  Array.Resize(ref arr, 3);
}

if ((num / 10000 % 10) >= 1) //5 цифра
{
  arr[4] = num / 10000 % 10;
}
else
{
  Array.Resize(ref arr, 4);
}
if ((num / 100000 % 10) >= 1)  //6 цифра
{
  arr[5] = num / 100000 % 10;
}
else
{
  Array.Resize(ref arr, 5);
}


for (int i = 0; i < arr.Length; i++)
{
  System.Console.Write(arr[i] + " ");
}



//(num.ToString().Reverse().ToArray())


