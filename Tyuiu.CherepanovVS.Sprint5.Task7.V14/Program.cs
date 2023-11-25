using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.CherepanovVS.Sprint5.Task7.V14.Lib;

namespace Tyuiu.CherepanovVS.Sprint5.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт5                                                                   *");
            Console.WriteLine("*Тема: Добавление к решению итоговых проектов по спринту.                  *");
            Console.WriteLine("*Задание #7                                                                *");
            Console.WriteLine("*Вариант #14                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан файл, C:DataSprint5 InPutDataFileTask7V14 (файл взять из архива      *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную C: DataSprint5 и        *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных. Заменить *");
            Console.WriteLine("* все строчные латинские буквы на заглавные. Полученный результат          *");
            Console.WriteLine("* сохранить в файл OutPutDataFileTask7V14.txt.                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            string path = $@"{Directory.GetCurrentDirectory()}\Sprint5Task7\InPutDataFileTask7V14.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\Sprint5Task7\OutPutDataFileTask7V14.txt";
            Console.WriteLine("Данные находятся в файле:" + path);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }

}
