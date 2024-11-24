
namespace Tyuiu.KulkoDA.Sprint5.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Даша\source\repos\Tyuiu.KulkoDA.Sprint5\Tyuiu.KulkoDA.Sprint5.Task3.V6\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}