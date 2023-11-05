using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShpilevayaAS.Sprint4.Task3.V18.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint4.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнила: Шпилевая А. С. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант 18                                                              *");
            Console.WriteLine("* Выполнила: Шпилевая Арина Станиславовна | ИИПб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9. Найдите максимальный     *");
            Console.WriteLine("* элемент в последней строке массива.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[,] arrayNums = new int[5, 5] { { 2, 4, 2, 7, 7 },
                                               { 4, 7, 9, 9, 7 },
                                               { 8, 5, 5, 6, 5 },
                                               { 7, 7, 5, 2, 9 },
                                               { 9, 3, 7, 9, 8 } };

            Console.WriteLine("Массив:");
            for (int i = 0; i < arrayNums.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNums.GetLength(1); j++)
                {
                    Console.Write($"{arrayNums[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(arrayNums);

            Console.WriteLine("Максимальный элемент в последней строке массива = " + result);
            Console.ReadKey();
        }
    }
}
