//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 //длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 //либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
  //лучше обойтись исключительно массивами.

string[] initialArray = { "Дон", "2", "-5", "Волга", "Днепр", "Москва", "9", "7", "Лена", "Амур" };
int count = 0;

for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        count++;
    }
}

string[] result = new string[count];
count = 0; 
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        result[count] = initialArray[i];
        count++;
    }
}


Console.WriteLine("Исходный массив строк: {0}", string.Join(", ", initialArray));
Console.WriteLine("Отфильтрованный массив строк (длина <= 3): {0}", string.Join(", ", result));
