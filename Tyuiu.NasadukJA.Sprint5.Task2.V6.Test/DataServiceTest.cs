using System.IO;

using Tyuiu.NasadukJA.Sprint5.Task2.V6.Lib;

namespace Tyuiu.NasadukJA.Sprint5.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}