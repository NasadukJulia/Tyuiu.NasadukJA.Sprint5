using Tyuiu.NasadukJA.Sprint5.Task2.V6.Lib;

// See https://aka.ms/new-console-template for more information

int[,] mtrx = new int[3, 3] { { -2, 1, 8 },
                              {-4, -7, 8 },
                              {6, 5, 5 } };

int rows = mtrx.GetUpperBound(0) + 1;
int columns = mtrx.Length / rows;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры. Заменить + элементы массива на 1, а - на 0.    *");
Console.WriteLine("* Сохранить результат в OutPutFileTask2.txt                               *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }

    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(mtrx);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
