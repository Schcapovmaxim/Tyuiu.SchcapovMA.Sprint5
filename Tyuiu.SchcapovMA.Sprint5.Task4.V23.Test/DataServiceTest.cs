using Tyuiu.SchcapovMA.Sprint5.Task4.V23.Lib;
using System.IO;
namespace Tyuiu.SchcapovMA.Sprint5.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Haier\AppData\Local\Temp\InPutDataFileTask4V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}