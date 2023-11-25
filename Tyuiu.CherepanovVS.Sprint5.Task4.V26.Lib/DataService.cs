using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.CherepanovVS.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round(((Math.Pow(Convert.ToDouble(strX), 3) + Math.Sin(Convert.ToDouble(strX))) * Math.Cos(Convert.ToDouble(strX))), 3);
            return res;

        }
    }
}
