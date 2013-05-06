using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamProject
{
    class Zhilkin
    {
        public static void umnoz(int u)
        {
            Console.WriteLine("Умножение на {0}", u);
            for (int i = 0; i < 5; i++)
                for (int k = 0; k < 5; k++)
                {
                    MainClass.Matrix2[i, k] = MainClass.Matrix[i, k] * u;
                }
        }

        public static void Zhilla()
        {
            umnoz(2);
            MainClass.display(MainClass.Matrix2);
        }
    }
}
