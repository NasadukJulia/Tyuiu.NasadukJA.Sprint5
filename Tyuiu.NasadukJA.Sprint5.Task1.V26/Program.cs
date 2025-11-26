using Tyuiu.NasadukJA.Sprint5.Task1.V26.Lib;

// See https://aka.ms/new-console-template for more information

int startValue = -5;
int stopValue = 5;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Табулировать функцию F(x) = (2x + 6)/(cos(x) + x)-3 на [-5; 5] шагом 1. *");
Console.WriteLine("* При делении на ноль вернуть 0. Округлить значения до двух знаков.       *");
Console.WriteLine("* Сохранить результат в OutPutFileTask1.txt                               *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("startValue = " + startValue);
Console.WriteLine("stopValue = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(startValue, stopValue);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
