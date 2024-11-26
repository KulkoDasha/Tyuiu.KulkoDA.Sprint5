using Tyuiu.KulkoDA.Sprint5.Task5.V2.Lib;

namespace Tyuiu.KulkoDA.Sprint5.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор значений. Найти среднее всех             *");
            Console.WriteLine("* положительных значений.                                                 *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            string path = @"C:\DataSprint5\InPutDataFileTask5V2.txt";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Данные находятся в файле: " + path);
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
