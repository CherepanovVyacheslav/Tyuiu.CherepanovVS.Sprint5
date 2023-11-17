using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint5.Task3.V26.Lib;

namespace Tyuiu.CherepanovVS.Sprint5.Task3.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 5                                                                  *");
            Console.WriteLine("*Тема: Потоковый метод записи данных в бинарный файл.                      *");
            Console.WriteLine("*Задание #3                                                                *");
            Console.WriteLine("*Вариант #26                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дано выражение , вычислить его значение при x = 2, результат сохранить в *");
            Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до     *");
            Console.WriteLine("* трёх знаков после запятой.                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int x = 2;
            Console.WriteLine("x = " + x);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл:" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
