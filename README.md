Контрольная работа
==================

## Задача ##
* Создать репозиторий на GitHub.
* Составить блок-схему алгоритма выполнения задачи.
* Снабдить репозиторий оформленным текстовым описанием решения задачи.
* Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна трём символам.
* Использовать контроль версий в работе над проэктом.

## Описание решения задачи ##
* Задаём массив строк:
string[] Array =
{ "Sunday", "2",
"Monday", "33",
"Tuersday",
"Wednesday", "one",
"Thirsday", ";-)",
"Friday", "O7",
"Saturday" };
* Выводим массив в консоль:
Console.WriteLine("[{0}]", string.Join(", ", Array));
* Для каждого элемента исходного массивы проводим проверку на соответствие заданным условиям (element.Length <= 3):
foreach (var element in Array)
{
    if (element.Length <= 3)
    {
        ResultArray[realSize] = element;
        realSize++;
    }
}
* Если элемент соответствует требуемым условиям, записываем его в новый массив(ResultARRay), если нет, то пропускаем.
* Выводим полученный массив:
Console.WriteLine("[{0}]", string.Join(" ", ResultArray));


