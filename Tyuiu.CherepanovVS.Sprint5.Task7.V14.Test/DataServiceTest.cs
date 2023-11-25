using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.CherepanovVS.Sprint5.Task7.V14.Lib;

namespace Tyuiu.CherepanovVS.Sprint5.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint5\Tyuiu.CherepanovVS.Sprint5.Task7.V14\bin\Debug\Sprint5Task7\OutPutDataFileTask7V14.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }

}
