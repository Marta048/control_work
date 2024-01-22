# control_work
# Решение задачи: Фильтрация массива строк

## Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно задать на старте выполнения алгоритма.

## Решение 
*Создание массива*

```
string[] initialArray = { "Дон", "2", "-5", "Волга", "Днепр", "Москва", "9", "7", "Лена", "Амур" };
int count = 0;
```
*Подсчет кол-ва отфильтрованых строк*

```
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        count++;
    }
}
```

*Создание результирующего массива и обнуление счетчика*
```
string[] result = new string[count];
count = 0;
```

*Заполнение результирующего массива отфильтрованными строками*


```
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        result[count] = initialArray[i];
        count++;
    }
}
```

*Вывод результата в консоль*
```
Console.WriteLine("Исходный массив строк: {0}", string.Join(", ", initialArray));
Console.WriteLine("Отфильтрованный массив строк (длина <= 3): {0}", string.Join(", ", result));

```

Был создан массив строк, каждый элемент проверялся на кол-во символовю Те элементы, которые содержали в себе меньше 3 или 3 элнмнта, добалены в новый массив и выведены в консоль.

