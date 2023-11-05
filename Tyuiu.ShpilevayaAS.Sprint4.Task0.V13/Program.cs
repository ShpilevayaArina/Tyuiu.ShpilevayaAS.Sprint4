using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShpilevayaAS.Sprint4.Task0.V13.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint4.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Шпилевая А. С. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант 13                                                              *"); 
            Console.WriteLine("* Выполнила: Шпилевая Арина Станиславовна | ИИПб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму четных  *");
            Console.WriteLine("* элементов массива.  {2, 6, 2, 3, 4, 5, 4, 9, 7, 8}                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            Console.WriteLine("Исходный массив:");
            for (int item = 0; item < numsArray.Length; item++)
            {
                Console.Write(numsArray[item] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetSumEvenArrEl(numsArray);

            Console.WriteLine("Сумма четных элементов = " + result);
            Console.ReadKey();
        }
    }
}
