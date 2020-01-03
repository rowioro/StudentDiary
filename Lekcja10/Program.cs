using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zmienne typu referencyjnego sa wskaznikami do obiektow!

            Diary diary = new Diary();
            diary.AddRating(4);
            diary.AddRating(4);
            Diary diary1 = diary;
            diary1.AddRating(5);
            Diary diary2 = diary;
            diary2.AddRating(3);

            diary2.ShowRaitings();
            Console.WriteLine("Najwyzsza osena: " + diary1.MaxRating());
            Console.WriteLine("Najnizsza osena: " + diary.MinRating());
            Console.WriteLine("Srednia ocen = " + diary2.CalculateAverage());

            Console.ReadKey();
        }
    }
}
