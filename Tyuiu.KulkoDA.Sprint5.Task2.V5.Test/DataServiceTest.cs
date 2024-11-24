using Tyuiu.KulkoDA.Sprint5.Task2.V5.Lib;
namespace Tyuiu.KulkoDA.Sprint5.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Даша\source\repos\Tyuiu.KulkoDA.Sprint5\Tyuiu.KulkoDA.Sprint5.Task2.V5\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}