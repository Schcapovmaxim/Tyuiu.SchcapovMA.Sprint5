using Tyuiu.SchcapovMA.Sprint5.Task7.V5.Lib;
namespace Tyuiu.SchcapovMA.Sprint5.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Щапов М.А. | ИБКСб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V5.txt (файл взять из       *");
            Console.WriteLine("* архива согласно вашему варианту.Создать папку в ручную С:\\DataSprint5\\*");
            Console.WriteLine("* и скопировать в неё файл) в котором есть набор символьных данных.       *");
            Console.WriteLine("* Удалить все латинские буквы из файла.Полученный результат сохранить в   *");
            Console.WriteLine("* файл OutPutDataFileTask7V5.txt.                                         *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\Users\Haier\AppData\Local\Temp\InPutDataFileTask7V5.txt";
            string pathSaveFile = @"C:\Users\Haier\AppData\Local\Temp\OutPutDataFileTask7.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
