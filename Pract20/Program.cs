using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pract20
{
    // Определение делегата
    delegate double CircleOperation(double radius);

    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра делегата и привязка к методам
            CircleOperation circumference = CalculateCircumference;
            CircleOperation area = CalculateArea;
            CircleOperation volume = CalculateVolume;

            // Радиус окружности
            double radius = 5.0;

            // Вычисление и вывод результатов
            Console.WriteLine($"Длина окружности с радиусом {radius}: {circumference(radius)}");
            Console.WriteLine($"Площадь круга с радиусом {radius}: {area(radius)}");
            Console.WriteLine($"Объем шара с радиусом {radius}: {volume(radius)}");
        }

        // Метод для вычисления длины окружности
        static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        // Метод для вычисления площади круга
        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Метод для вычисления объема шара
        static double CalculateVolume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }
}