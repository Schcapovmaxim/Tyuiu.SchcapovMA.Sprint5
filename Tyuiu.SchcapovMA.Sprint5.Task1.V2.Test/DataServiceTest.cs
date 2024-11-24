using Tyuiu.SchcapovMA.Sprint5.Task1.V2.Lib;
using System.IO;
namespace Tyuiu.SchcapovMA.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Haier\AppData\Local\Temp\OutPutFileTask1.txt";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}