using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seconda_prova_verifica_git
{
    internal class Libro
    {
<<<<<<< HEAD

        public class Libro
        {
=======
        
>>>>>>> Biblioteca
            public string autore { get; set; }
            public string editore { get; set; }
            public string titolo { get; set; }
            public string pubblicazione { get; set; }
            public string nPagine { get; set; }
            public string prestito { get; set; }


            public Libro(string a, string e, string t, string p, string nP, string pr)
            {
                this.autore = a;
                this.editore = e;
                this.titolo = t;
                this.pubblicazione = p;
                this.nPagine = nP;
                this.prestito = pr;
            }


            // metodi:

            public string ToStringLibro()
            {
                return "autore: " + autore + "editore: " + editore + "titolo: " + titolo + "pubblicazione: " + pubblicazione + "numero di pagine: " + nPagine + "è in prestito: " + prestito;

            }

            public void TimeToRead()
            {
                //if (Libro.nPagine) // come creare un oggetto generico che mi permetta di fare questo controllo su qualsiasi oggetto che chiama questo metodo
            }
<<<<<<< HEAD
        }
=======
        
>>>>>>> Biblioteca
    }
}
