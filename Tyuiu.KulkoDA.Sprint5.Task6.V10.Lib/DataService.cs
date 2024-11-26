using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KulkoDA.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(",", "");
                    line = line.Replace(".", "");
                    string[] a = line.Split(' ').ToArray();
                    for(int i = 0; i < a.Length; i++)
                    {
                        if (a[i].Length == 4)
                            res++;
                    }
                }
            }
            return res;
        }
    }
}
