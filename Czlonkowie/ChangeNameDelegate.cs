using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czlonkowie
{
    // Tworzymy DELEGAT, ktory przyjmuje 2 argumenty (obiekt i klase) !!!
    public delegate void ChangeNameDelegate(object sender, ChangeNameEventArgs args);
}
