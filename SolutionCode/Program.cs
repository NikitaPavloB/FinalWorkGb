// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

string[] FilterArray(string[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Trim().Length <= 3)
    {
      count++; // удаление пробелов в начале и конце строки
    }
  }

  string[] result = new string[count];
  int index = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Trim().Length <= 3) // удаление пробелов в начале и конце строки
    {
      result[index] = array[i].Trim(); // удаление пробелов в начале и конце строки
      index++;
    }
  }

  return result;
}

void PrintArray(string[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"\"{array[i]}\"");
    if (i != array.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
}


Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine());

string[] array = new string[n];
for (int i = 0; i < n; i++)
{
  Console.Write($"Введите строку {i + 1}: ");
  array[i] = Console.ReadLine().Trim(); // удаление пробелов в начале и конце строки
}

string[] result = FilterArray(array);

Console.WriteLine();

Console.WriteLine("Исходный массив:");
PrintArray(array);

Console.WriteLine();

Console.WriteLine("Массив с элементами длиной не более 3 символов:");
PrintArray(result);
