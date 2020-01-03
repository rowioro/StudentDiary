﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        // Stan. Wprowadzanie ocen do listy

        List<float> ratings = new List<float>();

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

        public float CalculateAverage()
        {
            float sum = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            return sum / ratings.Count();
        }

        public float MaxRating()
        {

            return ratings.Max();
        }

        public float MinRating()
        {

            return ratings.Min();
        }
    }
}