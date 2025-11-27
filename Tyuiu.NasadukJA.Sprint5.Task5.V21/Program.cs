using Tyuiu.NasadukJA.Sprint5.Task5.V21.Lib;


// See https://aka.ms/new-console-template for more information

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Найти факториал наибольшего целого числа, которое делится на 2, в файле.*");
Console.WriteLine("* Полученный результат вывести на консоль.                                *");
Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V21.txt");

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);

Console.WriteLine(res);
Console.ReadKey();
