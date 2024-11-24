using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Data.Common;
namespace Tyuiu.KulkoDA.Sprint5.Task2.V5.Lib
{
    public class DataService : ISprint5Task2V5
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            if (fileExsist)
            {
                File.Delete(path);
            }
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i,j]%2!=0)
                    {
                        matrix[i,j] = 0;
                    }

                }
            }
            string str = "";
            for(int i = 0; i < rows;i++)
            {
                for(int j = 0;j<cols;j++)
                {
                    if (j != cols - 1)
                        str += matrix[i, j] + ";";
                    else str += matrix[i, j];
                }
                if(i!=rows - 1)
                {
                    File.AppendAllText(path, str+Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);

                }
                str = "";
            }
            return path;
        }
    }
}
