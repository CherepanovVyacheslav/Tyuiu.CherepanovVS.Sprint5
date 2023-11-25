using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.CherepanovVS.Sprint5.Task5.V24.Lib;

namespace Tyuiu.CherepanovVS.Sprint5.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint5\Tyuiu.CherepanovVS.Sprint5.Task5.V24\bin\Debug\InPutDataFileTask5V24.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
