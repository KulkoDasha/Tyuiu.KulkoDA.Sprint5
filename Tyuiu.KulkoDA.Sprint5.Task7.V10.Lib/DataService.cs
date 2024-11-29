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
            string f =File.ReadAllText(path);
            string str = "";
            
            foreach(char ch in f)
            {
                if ((ch >= 97 && ch <= 122) && (char.IsUpper(ch)))
                {
                    str += char.ToLower(ch);
                }
                else
                {
                    str += ch;
                }
                    
                    
             File.AppendAllText(Savepath, str);
                
            }
            
            return Savepath;
        }
    }
}
