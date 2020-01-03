using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(4.5f);
            //diary.AddRating(4.8f);
            //diary.AddRating(2.5f);
            diary.AddRating();
            Console.WriteLine("Srednia twoich ocen = " + diary.CalculateAverage());
            Console.WriteLine("Najlepsza twoja ocena to " + diary.MaxRating());
            Console.WriteLine("Najgorsza twoja ocena to " + diary.MinRating());
        
            Console.ReadKey();
        }
    }
}
