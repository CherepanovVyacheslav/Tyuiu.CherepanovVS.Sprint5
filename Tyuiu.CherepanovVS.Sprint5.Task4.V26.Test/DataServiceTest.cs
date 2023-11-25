using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint5.Task4.V26.Lib;
using System.IO;

namespace Tyuiu.CherepanovVS.Sprint5.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint5\Tyuiu.CherepanovVS.Sprint5.Task4.V26\bin\Debug\Sprint5Task4\InPutDataFileTask4V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
