using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ParametryMetody
{
    class Program
    {
        public static void GiveName(ref Diary diary)
        {
            // Przypisujemy wskaznikowi "diary" nowy OBIEKT(wartosc) !!!
            diary = new Diary();
            diary.Name = "Teraz jestem Alunia";

        }

        // Nie zapominaj!!! 
        // Do metody zostaje wyslana kopia zmiennej!!! Chyba, ze uzyjemy operatora "ref" lub "out"!!!
        // Uzywajac operatora "out" nie musimy inicjowac zmiennej przed jej wyslaniem do metody !!!
        // Inicjacja nastapi w metodzie !!!
        public static void Iteracja(out int x)
        {
            x = 10;
            x++;
        }
        static void Main(string[] args)
        {
            PassByValueAndRef();

            //Immutable();

            //Arrays();

            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Speak("Gute Nacht Aluniu. Schlaf gut!");

            //string name1 = "Robert";
            //string name2 = "robert";
            //bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
            //Console.WriteLine(areEqual);


            Console.ReadKey();
        }

        private static void Arrays()
        {
            float[] raitings = new float[4];
            addRaitings(raitings);
        }

        private static void addRaitings(float[] raitings)
        {
            for (int i = 0; i < raitings.Length; i++)
            {
                raitings[i] = float.Parse( Console.ReadLine());
            }
            foreach (var item in raitings)
            {
                Console.Write(item+"   ");
            }
        }

        private static void Immutable()
        {
            string name = "  Robert Stefaniak  ";
            name = name.Trim();
            Console.WriteLine(name);

            DateTime date = new DateTime(2020, 1, 18);
            date = date.AddHours(48);
            Console.WriteLine(date);
        }

        private static void PassByValueAndRef()
        {
            Diary diary1 = new Diary();
            Diary diary2 = diary1;

            // Wszystkie 3 zmienne(wskazniki) referencyjne (diary1, diary2, diary) wskazuja na jeden obiekt !!!
            // Pomimo wyslania parametru "diary1" i jego ZMIANY w metodzie, ZMIANY te sa widoczne pod innymi wskaznikami !!!
            // W funkcji przekazujemy WARTOSC, ktora wskazuje wskaznik "diary1" !!!
            GiveName(ref diary2);
            Console.WriteLine(diary2.Name);

            int x1;

            // Nie zapominaj!!! 
            // Do metody zostaje wyslana kopia zmiennej!!! Chyba, ze uzyjemy operatora "ref" lub "out"!!!
            // Uzywajac operatora "out" nie musimy inicjowac zmiennej przed jej wyslaniem do metody !!!
            // Inicjacja nastapi w metodzie !!!
            Iteracja(out x1);
            Console.WriteLine(x1);
        }
    }
    public class Diary
    {
        public string Name { get; set; }
        public Diary()
        {
            this.Name = "Jestem Robert";
        }
    }

}
