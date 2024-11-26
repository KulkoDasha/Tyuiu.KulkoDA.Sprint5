using System.IO;
using System.Text;
using Tyuiu.KulkoDA.Sprint5.Task7.V10.Lib;
namespace Tyuiu.KulkoDA.Sprint5.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Заменить все          *");
            Console.WriteLine("* заглавные латинские буквы на строчные.                        *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            string path = @"C:\DataSprint5\InPutDataFileTask7V10.txt";
            string Savepath = @"C:\DataSprint5\OutPutDataFileTask7V10.txt";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Данные находятся в файле: " + path);
            Savepath = ds.LoadDataAndSave(path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + Savepath + " Создан!");

            Console.ReadKey();
        }
    }
}
