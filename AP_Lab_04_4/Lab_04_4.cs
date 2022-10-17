// Lab_04_4.cs
// Якубовський Владислав
// Лабораторна робота № 4.4
// Табуляція функції, заданої графіком.
// Варіант 24
using System;

namespace AP_Lab_04_4
{
    internal class Lab_04_4
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть змінні \"xp\", \"xk\", \"dx\", \"R\" по черзі через крапку з комою: ");

            string[] varArray = Console.ReadLine().Split(';');
            
            double xp = Double.Parse(varArray[0].Replace('.', ',')),
                xk = Double.Parse(varArray[1].Replace('.', ',')),
                dx = Double.Parse(varArray[2].Replace('.', ',')),
                R = Double.Parse(varArray[3].Replace('.', ',')),
                y;

            // Виведення "шапки" таблиці
            Console.WriteLine("+---------------+---------------+\n" +
                "|\tx\t|\tF\t|\n" +
                "+---------------+---------------+");

            // Розрахунок значень та виведення основної частини таблиці
            for (double x = xp; x <= xk; x += dx)
            {
                if (x < 0)
                    y = (-R / 6 * x) - R;

                else if (x > 0 && x < R)
                    y = -Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2));

                else if (x > R && x < (2 * R))
                    y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x - (2 * R), 2));

                else y = R;

                Console.WriteLine($"|\t{String.Format("{0:0.##}", x)}\t|\t{String.Format("{0:0.##}", y)}\t|\n" +
                    $"+---------------+---------------+");
            }

            Console.ReadLine();
        }
    }
}