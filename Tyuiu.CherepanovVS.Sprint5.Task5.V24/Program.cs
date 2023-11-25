using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.CherepanovVS.Sprint5.Task5.V24.Lib;

namespace Tyuiu.CherepanovVS.Sprint5.Task5.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 5                                                                  *");
            Console.WriteLine("*Тема: Чтение набора данных из текстового файла.                           *");
            Console.WriteLine("*Задание #5                                                                *");
            Console.WriteLine("*Вариант #24                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан файл С: DataSprint5 InPutDataFileTask5V24.txt (файл взять из архива  *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С: DataSprint5  и       *");
            Console.WriteLine("* cкопировать в неё файл) в котором есть набор значений. Найти сумму всех  *");
            Console.WriteLine("* двузначных целых чисел в файле. Полученный результат вывести на консоль. *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            string path = @"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint5\Tyuiu.CherepanovVS.Sprint5.Task5.V24\bin\Debug\InPutDataFileTask5V24.txt";
            Console.WriteLine("Данные находятся в файле:" + path);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма целых двузначных элементов файла = " + res);
            Console.ReadKey();
        }
    }
}