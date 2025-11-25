using System.IO;

using Tyuiu.NasadukJA.Sprint5.Task0.V21.Lib;

namespace Tyuiu.NasadukJA.Sprint5.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Julia\source\repos\Tyuiu.NasadukJA.Sprint5\Tyuiu.NasadukJA.Sprint5.Task0.V21\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
