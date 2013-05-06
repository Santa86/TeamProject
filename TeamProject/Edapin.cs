using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamProject
{
    class Edapin
    {
        public static void sum(int s)
        {
            Console.WriteLine("Увеличение на {0}", s);
            for (int i = 0; i < 5; i++)
                for (int k = 0; k < 5; k++)
                {
                    MainClass.Matrix2[i, k] = MainClass.Matrix[i, k] + s;
                }
        }

        public static void Santa()
        {
            sum(10);
            MainClass.display(MainClass.Matrix2);
        }
    }
}
