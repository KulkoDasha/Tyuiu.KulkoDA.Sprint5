using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.KulkoDA.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double y = Math.Round(x / (Math.Sqrt(x * x + x)),3);
            using(BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate),Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
