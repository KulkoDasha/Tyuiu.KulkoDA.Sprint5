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
            string str =File.ReadAllText(path);
            string newstr = "";
            
            foreach(char s in str)
            {
                if ((s >= 'A' && s <= 'Z') && (char.IsUpper(s)))
                {
                    newstr += char.ToLower(s);
                }
                else
                {
                    newstr += s;
                }
              
            }
            File.AppendAllText(Savepath, newstr);
            return Savepath;
        }
    }
}
