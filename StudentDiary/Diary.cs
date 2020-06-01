using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    public class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
            count++;
        }
        // Stan. Wprowadzanie ocen do listy

        List<float> ratings;

        // Operator "static" oznacza zmienna statyczna dostepna dla wszystkich obiektow danej klasy !!!
        public static long count = 0;

        public string Name { get; set; }

        // Metody. Obliczanie sredniej ocen. Wyznaczanie najwiekszej i najmniejszej oceny.

        public void AddRating()
        {
            float rating;
            //int count_ratings;
            //Console.Write("Ile ocen chcesz wprowadzic do dzienniczka: ");
            //count_ratings = int.Parse(Console.ReadLine());
            //for (int i = 0; i < count_ratings; i++)

            for (; ; )
            {
                Console.Write("Dodaj ocene do dzienniczka: ");

                // Funkcja "TryParse" konwertuje podana wartosc na float i sprawdza czy jest liczba !!!
                // Jezeli wartosc jest liczba to "bool result" jest true i wartosc zostaje przypisana do zmiennej "rating" !!!
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (result == false)
                {
                    Console.WriteLine("Nie podales oceny!");
                }
                else if (result)
                {
                    if (rating == 0)
                        break;
                    else if (rating >= 1 && rating <= 6)
                    {
                        ratings.Add(rating);
                    }
                    else
                        Console.WriteLine("Podales ocene spoza przedzialu!");
                }

            }
        }

        public DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics diaryStatistics = new DiaryStatistics();

            float sum = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            diaryStatistics.AverageGrade = sum / ratings.Count();
            diaryStatistics.MaxGrade = ratings.Max();
            diaryStatistics.MiniGrade = ratings.Min();

            return diaryStatistics;
        }

        //public float CalculateAverage()
        //{
        //    float sum = 0;
        //    foreach (var rating in ratings)
        //    {
        //        sum += rating;
        //    }
        //    return sum / ratings.Count();
        //}

        //public float MaxRating()
        //{

        //    return ratings.Max();
        //}

        //public float MinRating()
        //{

        //    return ratings.Min();
        //}
    }
}