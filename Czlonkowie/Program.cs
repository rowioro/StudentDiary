using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czlonkowie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parametry(1, 2, 3, 4);
            //Parametry(1, 2, 4, 0, 0, 0, 25, 35);
            //Parametry(999);

            Imie imie = new Imie();

            // Do WSKAZNIKOW DELEGATOW przypisujemy metoode !!!
            imie.ChangeName += new ChangeNameDelegate(Komunikat);

            // Do wskaznika "ChangeName" mozemy przypisac sama metode !!!
            imie.ChangeName += Komunikat2;

            //imie.Name = "Robert";
            try
            {
                Console.Write("Podaj imie: ");
                imie.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Cos poszlo nie tak!");
            }
            finally
            {

            }


            Console.ReadKey();
        }

        private static void Komunikat(object sender, ChangeNameEventArgs args)
        {
            //Console.WriteLine("Zmiana z "+args.ExistingName+" na "+args.NewName);
            // Alternatywnie...
            Console.WriteLine($"Zmiana z {args.ExistingName} na {args.NewName}");
        }
        private static void Komunikat2(object sender, ChangeNameEventArgs args)
        {
            Console.WriteLine("Dokonales zmiany!!!");
        }

        // Przekazywanie zmiennej liczby parametrow do metody za pomoca operatora "params"  !!!
        private void Parametry(params int[] vs)
        {
            Console.WriteLine(vs[vs.Length - 1]);
        }

        // Wykozystanie PLACE HOLDER-ow i formatowanie zmiennych np. {1:F2} na liczbe float z dwoma miejscami po przecinku !!!
        private void Parametry(int v1)
        {
            Console.WriteLine("{0}:{1:F2}:{2}", v1, 6, 6);

            // Alternatywnie...
            Console.WriteLine($"{v1}:{9:F3}:{100:C}");
        }
    }
    class Imie
    {
        string _name = "xxx";
        public string Name
        {
            // "get" pozwala pobrac wlasciwosc !!!
            get
            {
                return _name.ToUpper();
            }

            // "set" pozwala ustawic wlasciwosc !!!
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pole nie moze byc puste!");
                }
                if (_name != value && ChangeName != null)
                {
                    ChangeNameEventArgs args = new ChangeNameEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;
                    ChangeName(this, args);
                }
                _name = value;
            }
        }

        // Inicjujemy WSKAZNIK DELEGATA !!!
        public event ChangeNameDelegate ChangeName;
    }
}
