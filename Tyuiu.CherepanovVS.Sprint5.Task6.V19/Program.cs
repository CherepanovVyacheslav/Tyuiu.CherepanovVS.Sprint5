using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint5.Task6.V19.Lib;

namespace Tyuiu.CherepanovVS.Sprint5.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт5                                                                   *");
            Console.WriteLine("*Тема: Обработка текстовых файлов.                                         *");
            Console.WriteLine("*Задание #6                                                                *");
            Console.WriteLine("*Вариант #19                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан файл, C:DataSprint5 InPutDataFileTask6V19 (файл взять из архива      *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную C: DataSprint5 и        *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных. Найти    *");
            Console.WriteLine("* количество двузначных чисел в заданной строке.                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            string path = $@"{Directory.GetCurrentDirectory()}\Sprint5Task6\InPutDataFileTask6V19.txt";
            Console.WriteLine("Данные находятся в файле:" + path);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
