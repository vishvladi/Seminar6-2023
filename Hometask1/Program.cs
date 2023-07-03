// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int ReadInt(string message)
 {
    System.Console.Write(message);
    string text = Console.ReadLine();
    int inputedNum = Convert.ToInt32(text);
    return inputedNum;
 }
int[] GenerateArray(int len, int min, int max)//получение массива случайных чисел
{
   int[] array = new int [len];
   Random random = new Random();
    for (int i = 0;i < array.Length; i ++)
   {
       array[i] = random.Next(min, max + 1);
   }
    return array;
}
//int[] GenerateArray(int len)//получение массива  
//{
 //   int[] array = new int [len];
 //   for (int i = 0;i < array.Length; i ++)
 //   {
 //       array[i] = ReadInt($"Введите {i + 1} -й элемент");
 //   }
//  return array;
//}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
//    System.Console.Write($"a[{i}] = {array[i]}");
      System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();// Для перевода строки
}
int CountPositives(int[] array)
{
    int count = 0;
    for (int i = 0;i < array.Length; i ++)
    {
        if (array[i] > 0)
        count ++;
    }
    return count;
}
int arraylength = ReadInt("Введите длину массива: ");
int [] array = GenerateArray(arraylength, -5, 5);
PrintArray(array);
System.Console.WriteLine($"Количество положительных чисел в массиве {CountPositives(array)}");