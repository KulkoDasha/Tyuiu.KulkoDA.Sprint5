using Tyuiu.KulkoDA.Sprint5.Task6.V10.Lib;
namespace Tyuiu.KulkoDA.Sprint5.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V10.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
        public void Tet()
        {
            DataService ds  = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V10.txt";
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(3, res);
        }
    }
}