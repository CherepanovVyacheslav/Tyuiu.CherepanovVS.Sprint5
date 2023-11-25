using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.CherepanovVS.Sprint5.Task4.V26.Lib;

namespace Tyuiu.CherepanovVS.Sprint5.Task4.V26
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт5                                                                   *");
            Console.WriteLine("*Тема: Чтение данных из текстового файла                                   *");
            Console.WriteLine("*Задание #4                                                                *");
            Console.WriteLine("*Вариант #26                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан файл, C:DataSprint5 InPutDataFileTask4V0 (файл взять из архива       *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную C: DataSprint5 и        *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение. Прочитать  *");
            Console.WriteLine("* значение из файла и подставить вместо X в формуле. Вычислить значение по *");
            Console.WriteLine("* формуле (полученное значение округлить до трёх знаков полсе звпятой) и   *");
            Console.WriteLine("* полученный результат на консоль.                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            string path = $@"{Directory.GetCurrentDirectory()}\Sprint5Task4\InPutDataFileTask4V26.txt";
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
