using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seconda_prova_verifica_git
{
    internal class Biblioteca
    {
        List<Libro> libreria = new List<Libro>();
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string Orario { get; set; }

        public Biblioteca(List<Libro> l, string n, string i, string o)
        {
            this.libreria = l;
            Nome = n;
            Indirizzo = i;
            Orario = o;
        }

        public void CreaAggiungiLibro()
        {
            Console.WriteLine("inserire i parametri nel seguente ordine : autore, editore, titolo, pubblicazione, data, se è in prestito metti True e se è in biblioteca metti False")
            Libro l = new Libro(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine().ToUpper());
        }
    }
}
