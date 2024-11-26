using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KulkoDA.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            double f;
            double res = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    f = Convert.ToDouble(line);
                    if(f>0)
                    {
                        res += f;
                        count++;
                    }
                }
            }
            return Math.Round((res/count),3);
        }
    }
}
