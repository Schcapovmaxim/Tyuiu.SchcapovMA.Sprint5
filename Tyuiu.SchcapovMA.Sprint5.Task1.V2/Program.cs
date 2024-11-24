using Tyuiu.SchcapovMA.Sprint5.Task1.V2.Lib;
namespace Tyuiu.SchcapovMA.Sprint5.Task1.V2
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
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл.                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F (x) = (2x-3)/(cos(x)-2x)+ 5x - 6                        *");
            Console.WriteLine("* (произвести табулирование) на заданном диапазоне [-5; 5] с шагом 1.     *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть        *");
            Console.WriteLine("* значение О. результат сохранить в текстовый файл OutPutFileTask1.txt    *");
            Console.WriteLine("* и вывести на консоль в таблицу. Значения округлить до двух знаков       *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startValue,stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
