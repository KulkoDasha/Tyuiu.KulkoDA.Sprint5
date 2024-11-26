using System.IO;
using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KulkoDA.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            int count = 0;
            int f;
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(",", "");
                    int[] a = line.Split(' ').Select(int.Parse).ToArray();
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (Convert.ToInt32(a[i])>0)
                        {
                            sum += Convert.ToInt32(a[i]);
                            count++;
                        }
                    }
                }
            }
            return Math.Round((sum/count),3);
        }
    }
}
    