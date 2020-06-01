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
            Diary[] Uczniowie = new Diary[2];
            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Wprowadz oceny ucznia nr "+(i+1));
                Diary diary = new Diary();
                //diary.AddRating(5);
                //diary.AddRating(4.5f);
                //diary.AddRating(4.8f);
                //diary.AddRating(2.5f);

                diary.AddRating();

                //Console.WriteLine("Srednia twoich ocen = " + diary.CalculateAverage());
                //Console.WriteLine("Najlepsza twoja ocena to " + diary.MaxRating());
                //Console.WriteLine("Najgorsza twoja ocena to " + diary.MinRating());

                DiaryStatistics diaryStatistics = diary.ComputeStatistics();
                Console.WriteLine("Srednia twoich ocen = " + diaryStatistics.AverageGrade);
                Console.WriteLine("Najlepsza twoja ocena to " + diaryStatistics.MaxGrade);
                Console.WriteLine("Najgorsza twoja ocena to " + diaryStatistics.MiniGrade);
                Swiadectwo.Sprawdzenie((int)diaryStatistics.AverageGrade);

                //Console.WriteLine();
                //Console.WriteLine("Wprowadz oceny ucznia nr 2.");
                //Diary diary2 = new Diary();
                //diary2.AddRating();

                //diaryStatistics = diary2.ComputeStatistics();
                //Console.WriteLine("Srednia twoich ocen = " + diaryStatistics.AverageGrade);
                //Console.WriteLine("Najlepsza twoja ocena to " + diaryStatistics.MaxGrade);
                //Console.WriteLine("Najgorsza twoja ocena to " + diaryStatistics.MiniGrade);
            }

            Console.WriteLine(Diary.count);

            Console.ReadKey();
        }
    }
}
