using Tyuiu.KulkoDA.Sprint5.Task1.V4.Lib;
namespace Tyuiu.KulkoDA.Sprint5.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Даша\source\repos\Tyuiu.KulkoDA.Sprint5\Tyuiu.KulkoDA.Sprint5.Task1.V4\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}