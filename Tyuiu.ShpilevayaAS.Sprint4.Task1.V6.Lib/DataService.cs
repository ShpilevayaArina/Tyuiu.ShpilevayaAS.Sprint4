﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShpilevayaAS.Sprint4.Task1.V6.Lib
{
    public class DataService : ISprint4Task1V6
    {
        public int Calculate(int[] array)
        {
            int pr = 1;

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    pr *= item;
                }
            }

            return pr;
        }
    }
}
