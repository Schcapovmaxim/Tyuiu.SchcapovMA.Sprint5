﻿using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SchcapovMA.Sprint5.Task5.V28.Lib
{
    public class DataService : ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
            

        {
            int min = 1000;
            double res = 0;
            int fact = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lineReplace = line.Replace('.', ',');
                    string[] lineArray = lineReplace.Split(' ');
                    foreach (string number in lineArray)
                    {
                        double lineParse = double.Parse(number);
                        if ((lineParse > 0) && (lineParse % 5 == 0)) 
                        {
                            res = lineParse;
                            if (res < min)
                            {
                                min = (int)res;
                                
                            }
                        }
                    }
                    for (int i = 1; i <= min; i++)
                    {
                        fact *= i;
                    }
                }
            }
            return fact;
        }
    }
}
