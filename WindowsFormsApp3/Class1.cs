﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public delegate int getAnswer(int x, int y);
    class Class1
    {
        public static int getSum(int num1, int num2) {
            return num1 + num2;
        }
        public static int getDifference(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int getProduct(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int getQuotient(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
