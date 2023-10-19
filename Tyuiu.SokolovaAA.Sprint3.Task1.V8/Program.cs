﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint3.Task1.V8.Lib;
namespace Tyuiu.SokolovaAA.Sprint3.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Соколова А.А. | ACОиУБ-23-3";
            
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                          *");
            Console.WriteLine("* Тема: Оператор цикла while                                                                                           *");
            Console.WriteLine("* Задание #1                                                                                                         *");
            Console.WriteLine("* Вариант #8                                                                                                        *");
            Console.WriteLine("* Выполнил: Соколова Анастасия Александровна| ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда по формуле, при х=0,25                       *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 7;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
