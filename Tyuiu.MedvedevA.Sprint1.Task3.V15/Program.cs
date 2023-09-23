using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.MedvedevA.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Медведев А. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Медведев Андрей Валерьевич  | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу, которая запрашивает у пользователя         *");
            Console.WriteLine("* исходные данные, выполняет указанные расчёты и                          *");
            Console.WriteLine("* печатает результат на экране.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1 = 60;
            double v2 = 50;
            double s = 10;
            double t = 3;

            Console.WriteLine("Скорость первого автомобиля = " + v1 + " км/ч");
            Console.WriteLine("Скорость второго автомобиля = " + v2 + " км/ч");
            Console.WriteLine("Расстояние между автомобилями = " + s + " км");
            Console.WriteLine("Время затраченное на движение = " + t + " ч");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между автомобилями через " + t + " часов = " + ds.DistanceOverTime(v1, v2, s, t) + " км");

            Console.ReadKey();
        }
    }
}
