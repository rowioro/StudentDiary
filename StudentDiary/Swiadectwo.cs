using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    public static class Swiadectwo
    {
        public static void Sprawdzenie(float average)
        {
            string x = "Jestes";
            switch (average)
            {
                case 1:
                    Console.WriteLine(x+" mierny");
                    break;
                case 2:
                    Console.WriteLine(x+" niedostateczny");
                    break;
                case 3:
                    Console.WriteLine(x+" dostateczny");
                    break;
                case 4:
                    Console.WriteLine(x+" dobry");
                    break;
                case 5:
                    Console.WriteLine(x+" bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine(x+" WYBITNY");
                    break;
                default:
                    Console.WriteLine("Nie zostales oocniony!");
                    break;
            }
        }
    }
}
