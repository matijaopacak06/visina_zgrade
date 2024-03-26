using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visina_zgrade2
{
    internal class Neboder
    {
        int visina = 3, brojKatova; // definirali smo vrijednosti u int.//

        public int Visina { get => visina; set => visina = value; } // get uzima visinu a set postavlja visinu // 
        public int BrojKatova { get => brojKatova; set => brojKatova = value; } // get uzima BrojKatova a set postavlja BrojKatova //
        public int IzracunajVisinu (int BrojKatova) // 
        {
            visina = BrojKatova * Visina; // izracunali smo visinu tako sto smo Broj katova pomnozili sa  visinom zgrade.
            return visina; // vraca vrijednost u visinu. //
        }
    }
}
