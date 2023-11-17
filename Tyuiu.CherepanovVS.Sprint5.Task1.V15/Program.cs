using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint5.Task1.V15.Lib;

namespace Tyuiu.CherepanovVS.Sprint5.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 5                                                                  *");
            Console.WriteLine("*Тема: Класс File. Запись набора данных в текстовый файл                   *");
            Console.WriteLine("*Задание #1                                                                *");
            Console.WriteLine("*Вариант #15                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дана функция (произвести табултрование) f(x) на заданном диапозоне [-5,5]*");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль. При делении на ноль      *");
            Console.WriteLine("* вернуть значение 0. Результат сохранить в текстовый файл                 *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблицу. Значения округлить до*");
            Console.WriteLine("* двух знаков после запятой.                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("staetValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл:" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
