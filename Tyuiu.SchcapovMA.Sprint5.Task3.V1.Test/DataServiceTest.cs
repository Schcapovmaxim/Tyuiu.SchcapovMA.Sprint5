using Tyuiu.SchcapovMA.Sprint5.Task3.V1.Lib;
using System.IO;
namespace Tyuiu.SchcapovMA.Sprint5.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Haier\AppData\Local\Temp\OutPutFileTask3.bin";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}