using Tyuiu.KulkoDA.Sprint5.Task7.V10.Lib;
namespace Tyuiu.KulkoDA.Sprint5.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V10.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}