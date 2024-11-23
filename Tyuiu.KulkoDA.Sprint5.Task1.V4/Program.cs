using Tyuiu.KulkoDA.Sprint5.Task1.V4.Lib;
namespace Tyuiu.KulkoDA.Sprint5.Task1.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, на диапазоне[-5;5] с шагом 1.                             *");
            
            Console.WriteLine("*                                                                         *");
            int a = -5;
            int b = 5;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("StartValue = " + a);
            Console.WriteLine("StotValue = " + b);
            string res = ds.SaveToFileTextData(a,b);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + res + " Создан!");
            Console.ReadKey();
        }
    }
}
