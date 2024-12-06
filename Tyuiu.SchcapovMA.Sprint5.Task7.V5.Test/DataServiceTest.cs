using System.IO;
using Tyuiu.SchcapovMA.Sprint5.Task7.V5.Lib;
namespace Tyuiu.SchcapovMA.Sprint5.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\Users\Haier\AppData\Local\Temp\InPutDataFileTask7V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}