using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Reflection.PortableExecutable;
namespace Tyuiu.KulkoDA.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string Savepath = @"C:\DataSprint5\OutPutDataFileTask7V10.txt";
            FileInfo fileInfo = new FileInfo(Savepath);
            if (fileInfo.Exists )
            {
                File.Delete(Savepath);
            }
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach(char c in line)
                    {
                        if(char.IsUpper(c))
                        {
                            line.Replace(c, char.ToLower(c));
                        }
                    }
                    File.AppendAllText(Savepath, line);
                }
            }

            return Savepath;
        }
    }
}
