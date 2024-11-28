using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Reflection.PortableExecutable;
namespace Tyuiu.KulkoDA.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            
            string Savepath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V10.txt");
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
                    foreach(char ch in line)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if ((line[i] == line.ToUpper()[i]) & ((int)ch >= 97 && (int)ch <= 122))
                            {
                                line = line.Replace(line[i], line.ToLower()[i]);
                            }
                            else
                                line = line.Replace(line[i], line.ToUpper()[i]); ;
                        }
                    }
                    
                    File.AppendAllText(Savepath, line);
                }
            }
            
            return Savepath;
        }
    }
}
