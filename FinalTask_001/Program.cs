// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

string[] startArray = CreateArray();


string[] CreateArray()
{
  Console.WriteLine("Введите длину массива: ");
  int arrayLength = int.Parse(Console.ReadLine());
  string[] array = new string[arrayLength];
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write("Введите значение элемента: ");
    array[i] = (Console.ReadLine());
  }
  return array;
}

void PrintArray(string[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.WriteLine(array[^1] + "]");
}