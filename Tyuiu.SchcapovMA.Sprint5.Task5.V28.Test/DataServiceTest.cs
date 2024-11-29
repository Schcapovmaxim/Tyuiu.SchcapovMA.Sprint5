using System.IO;
using Tyuiu.SchcapovMA.Sprint5.Task5.V28.Lib;
namespace Tyuiu.SchcapovMA.Sprint5.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Haier\AppData\Local\Temp\InPutDataFileTask5V28.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}