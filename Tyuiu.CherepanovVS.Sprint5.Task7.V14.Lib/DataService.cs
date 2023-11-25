using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.CherepanovVS.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\Sprint5Task7\OutPutDataFileTask7V14.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    foreach (var str in line)
                    {
                            strLine+=Char.ToUpper(str);
                    }

                File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                strLine = "";
            }
            return pathSaveFile;
        }

    }
}
