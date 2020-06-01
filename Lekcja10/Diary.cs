using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja10
{
    class Diary
    {
        // Stan. Wprowadzanie ocen do listy

        List<float> ratings = new List<float>();

        // Metody. Obliczanie sredniej ocen. Wyznaczanie najwiekszej i najmniejszej oceny.
        /// <summary>
        /// Dodawanie ocen do listy
        /// </summary>
        /// <param name="rating">Nowa ocena</param>
        public void AddRating(float rating)
        {
            //float rating;
            //int count_ratings;
            //Console.Write("Ile ocen chcesz wprowadzic do dzienniczka: ");
            //count_ratings = int.Parse(Console.ReadLine());
            //for (int i = 0; i < count_ratings; i++)

            //for (; ; )
            //{
            //    Console.Write("Dodaj ocene do dzienniczka: ");
            //    bool result = float.TryParse(Console.ReadLine(), out rating);

            //    if (result == false)
            //    {
            //        Console.WriteLine("Nie podales oceny!");
            //    }
            //    else if (result)
            //    {
            //        if (rating == 0)
            //            break;
            //        else if (rating >= 1 && rating <= 6)
            //        {
            //            ratings.Add(rating);
            //        }
            //        else
            //            Console.WriteLine("Podales ocene spoza przedzialu!");
            //    }
            //}
            ratings.Add(rating);
        }
        /// <summary>
        /// Pokazuje wszystkie oceny
        /// </summary>
        public void ShowRaitings()
        {
            foreach (var item in ratings)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Oblicza srednia wszystkich ocen
        /// </summary>
        /// <returns>Srednia ocen</returns>
        public float CalculateAverage()
        {
            float sum = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            return sum / ratings.Count();
        }
        /// <summary>
        /// Podaje najwyzsza ocene
        /// </summary>
        /// <returns>Najwyzsza ocena</returns>
        public float MaxRating()
        {

            return ratings.Max();
        }
        /// <summary>
        /// Podaje najnizsza ocene
        /// </summary>
        /// <returns>Najnizsza ocena</returns>
        public float MinRating()
        {

            return ratings.Min();
        }
    }
}
