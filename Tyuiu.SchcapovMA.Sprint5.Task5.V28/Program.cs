using Tyuiu.SchcapovMA.Sprint5.Task5.V28.Lib;
namespace Tyuiu.SchcapovMA.Sprint5.Task5.V28
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
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V28.txt (файл взять из      *");
            Console.WriteLine("* архива согласно вашему варианту.Создать папку в ручную С:\\DataSprint5\\*");
            Console.WriteLine("* и скопировать в неё файл) в котором есть набор  значений.               *");
            Console.WriteLine("*Найти факториал наименьшего положительного целого числа, которое делится *");
            Console.WriteLine("* на 5, в файле.                                                          *");
            Console.WriteLine("*                                                                         *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\Users\Haier\AppData\Local\Temp\InPutDataFileTask4V23.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Факториал числа равен"+res);
            Console.ReadKey();
        }
    }
}
