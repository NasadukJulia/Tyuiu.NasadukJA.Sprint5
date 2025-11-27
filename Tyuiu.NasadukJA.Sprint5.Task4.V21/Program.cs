using Tyuiu.NasadukJA.Sprint5.Task4.V21.Lib;

// See https://aka.ms/new-console-template for more information

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле             *");
Console.WriteLine("* Вычислить значение по формуле и вернуть результат на консоль.           *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V21.txt");

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);

Console.WriteLine(res);
Console.ReadKey();
