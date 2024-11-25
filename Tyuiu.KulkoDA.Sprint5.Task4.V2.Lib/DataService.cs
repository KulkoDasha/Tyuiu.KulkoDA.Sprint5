using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KulkoDA.Sprint5.Task4.V2.Lib
{
    public class DataService : ISprint5Task4V2
    {
        public double LoadFromDataFile(string path)
        {
            string srt = File.ReadAllText(path);
            string s = srt.Replace(".",",");
            double x = Convert.ToDouble(s);
            double res = (Math.Cos(x)+3*x)/(0.25*x)+4-2.1*x;
            return Math.Round(res,3);
        }
    }
}
