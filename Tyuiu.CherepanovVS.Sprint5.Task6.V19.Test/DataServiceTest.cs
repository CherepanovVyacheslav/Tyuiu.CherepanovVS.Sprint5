using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.CherepanovVS.Sprint5.Task6.V19.Lib;

namespace Tyuiu.CherepanovVS.Sprint5.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint5\Tyuiu.CherepanovVS.Sprint5.Task6.V19\bin\Debug\Sprint5Task6\InPutDataFileTask6V19.txt";
            DataService ds = new DataService();
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint5\Tyuiu.CherepanovVS.Sprint5.Task6.V19\bin\Debug\Sprint5Task6\InPutDataFileTask6V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
