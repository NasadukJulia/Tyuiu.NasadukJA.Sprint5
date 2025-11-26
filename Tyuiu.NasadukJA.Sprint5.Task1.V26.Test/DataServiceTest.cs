using System.IO;

using Tyuiu.NasadukJA.Sprint5.Task1.V26.Lib;

namespace Tyuiu.NasadukJA.Sprint5.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
