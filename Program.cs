﻿// See https://aka.ms/new-console-template for more information
// Очистка консоли.
Console.Clear();
// Console.WriteLine("Hello, World!");

// --------------------------------------------------------------
/*
--ТЗ:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

--Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

--Пример:
    [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
    [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
    [“Russia”, “Denmark”, “Kazan”] → []
*/
// --------------------------------------------------------------
Console.WriteLine("Введите строки массива:");
int count = 0;
string[] ArrStrInit = new string[count];
string s;
string[] ArrStrTemp;

// Заполнение массива через консоль.
do
{
  s = Console.ReadLine()!;
  if (s != "")
  {
    count++;
    ArrStrTemp = new string[count];
    for (int i = 0; i < ArrStrTemp.Length - 1; i++)
      ArrStrTemp[i] = ArrStrInit[i];
    ArrStrTemp[count - 1] = s;
    ArrStrInit = ArrStrTemp;
  }
}
while (s != "");
// Вывод начального массива.
Console.WriteLine($"Начальный массив: [{string.Join(", ", ArrStrInit)}]\n");

int countNew = 0;
string[] ArrStrFinal;
// Нахождение размера массива "ArrStrFinal"
for (int i = 0; i < ArrStrInit.Length; i++)
  if (ArrStrInit[i].Length <= 3)
    countNew++;
ArrStrFinal = new string[countNew];

// Заполнение массива "ArrStrFinal"
int i1 = 0;
for (int i = 0; i < ArrStrInit.Length; i++)
  if (ArrStrInit[i].Length <= 3)
  {
    ArrStrFinal[i1] = ArrStrInit[i];
    i1++;
  }
// Вывод финального массива.
Console.WriteLine($"Редактированный массив: [{string.Join(", ", ArrStrFinal)}]\n");

// --------------------------------------------------------------