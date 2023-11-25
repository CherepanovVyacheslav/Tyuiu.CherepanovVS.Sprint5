using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.CherepanovVS.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
         
                    foreach (var str in line)
                    {
                        if (char.IsDigit(str) && str>=10 && str <=99)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
