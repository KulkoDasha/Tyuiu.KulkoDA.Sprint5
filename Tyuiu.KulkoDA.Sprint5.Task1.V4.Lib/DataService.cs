using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KulkoDA.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            if (fileExsist) 
            { 
                File.Delete(path); 
            }
            double y;
            string str;
            for(int i = startValue; i<=stopValue;i++)
            {
                y = Math.Round((Math.Cos(i)/(i+1)-Math.Cos(i)*1.3+3*i),2);
                if(i+1==0)
                    { y = 0; }
                str = Convert.ToString(y);
                if (i!=stopValue)
                {
                    File.AppendAllText(path, str+Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }

            }
            return (path);
        }
    }
}
