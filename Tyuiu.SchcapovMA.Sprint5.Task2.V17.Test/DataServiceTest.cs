using Tyuiu.SchcapovMA.Sprint5.Task2.V17.Lib;
using System.IO;
namespace Tyuiu.SchcapovMA.Sprint5.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Haier\AppData\Local\Temp\OutPutFileTask2.csv";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}