using System.IO;
using Tyuiu.SchcapovMA.Sprint5.Task6.V7.Lib;
namespace Tyuiu.SchcapovMA.Sprint5.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Haier\AppData\Local\Temp\InPutDataFileTask6V7.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 16;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Haier\AppData\Local\Temp\InPutDataFileTask6V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}