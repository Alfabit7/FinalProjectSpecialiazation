/*Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


/*
// РЕШЕНИЕ  1
// Очищаем консоль 
Console.Clear();

// Просим пользователея ввести  текст
Console.Write("Введите через пробел: ");
// Ввод сохраняем в новый массив очистив от лишних пробелов 
string[] userInput = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

// sizeUserInputFiltered хранит размер нового массива
int sizeUserInputFiltered = 0;

// Считает сколько элементов  в массиве соответстует условию длины меньше 3 символов
foreach (string el in userInput)
{
    if (el.Length <= 3) { sizeUserInputFiltered += 1; }
    else { continue; }
}
// Создаем новый массив размером sizeUserInputFiltered
string[] userInputFiltered = new string[sizeUserInputFiltered];

// Проверяем, что новый массив не пустой
if (sizeUserInputFiltered != 0)
{
    FilteredArray(userInput);
    // Выводим новый массив на экран 
    Console.Write($" Новый массив {String.Join("; ", userInputFiltered)};");

}
// Если массив пустой выводим сообщение на экран, что массив пуст.
else { Console.Write(" Новый массив  пуcт []"); }

// Функция заполняет новый массив элементами из принятого массива.
// В новый массив войдут те элементы, у которых кол-во символов  меньше либо равна 3
void FilteredArray(string[] arr)
{
    for (int i = 0, j = 0; i < userInput.Length; i++)
    {
        if (userInput[i].Length <= 3)
        {
            userInputFiltered[j] = userInput[i];
            j++;
        }
        else { continue; }
    }
}


*/

// РЕШЕНИЕ  2


Console.Clear();
// Просим пользователея ввести  текст
Console.Write("Введите через пробел: ");
// Ввод сохраняем в новый массив очистив от лишних пробелов 
string[] userInput = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

// sizeUserInputFiltered хранит размер нового массива
string elementLessThenThree = String.Empty;

// присваиваем в переменную elementLessThenThree через пробел  элементами массива длина которых меньше или равна 3 символам
foreach (string el in userInput)
{
    if (el.Length <= 3)
    {
        elementLessThenThree += el + " ";
    }
    else { continue; }
}
// Создаем новый массив из строки elementLessThenThree
string[] newArr = elementLessThenThree.Split(new char[] { ' ' });
// Выводим элементы нового массива newArr на экран 

if (elementLessThenThree != String.Empty)
{
    foreach (string el in newArr)
    {
        Console.Write(el + " ");
    }
}
else
{
    Console.Write("Новый массив пуст [ ]");
}