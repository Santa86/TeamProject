using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamProject
{
    class Parmanov
    {
        public static void delenie(int n)
        {
            Console.WriteLine("Деление на {0}", n);
            for (int i = 0; i < 5; i++)
                for (int k = 0; k < 5; k++)
                {
                    MainClass.Matrix2[i, k] = MainClass.Matrix[i, k] / n;
                }
        }

        public static void Parm()
        {
            delenie(2);
            MainClass.display(MainClass.Matrix2);
        }
    }
}
