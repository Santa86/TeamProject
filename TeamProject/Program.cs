using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamProject
{
    class Program
    {
        public static void select()
        {
            Console.Write("Чей проект выхотите запустить? (Парманов = p, Жилкин = z, Едапин = e)  ");
            string cons = Console.ReadLine();
            if (cons == "p")
            {
                Parmanov.Parm();
            }
        }

        public static void ext_sel()
        {
            Console.Write("Вы хотите продолжить? (y/n) ");
            string cont = Console.ReadLine();
            if(cont == "y")
            {
                select();
                ext_sel();
            }
            if (cont == "n")
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey(true);
            }
        }
        static void Main(string[] args)
        {
            MainClass.init();
            select();
            ext_sel();
        }
    }
}
