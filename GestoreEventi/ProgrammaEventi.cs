using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestoreEventi;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        //ATTRIBUTI
        private string titolo;
        private List<Evento> eventi;

        //COSTRUTTORE
        public ProgrammaEventi(string titolo, List<Evento> eventi)
        {
            this.titolo = titolo;   
            this.eventi = eventi;            
        }

        //GET
        public string GetTitolo()
        {
            return titolo;
        }

        //AGGIUNGI EVENTI ALLA LISTA
        public List<Evento> AggiungiEventi()
        {
            foreach(Evento events in eventi)
            {
                this.eventi.Add(events);
            }

            return this.eventi;
        }

        //STAMPA EVENTI CHE HANNO LO STESSO GIORNO NELLA LISTA 
        public void StampaEventiGiornalieri(DateTime dataDaControllare)
        {
            foreach (Evento events in this.eventi)
            {
                if(events.GetDataEvento() == dataDaControllare)
                {                   
                    Console.WriteLine(events.ToString());
                }
            }
        }

        public void Stampa()
        {
            int lunghezzaList = LunghezzaLista();
            Console.WriteLine("Il numero di eventi e': " + lunghezzaList);
            Console.WriteLine("Ecco il tuo programma eventi: ");
            Console.WriteLine(this.titolo);
            foreach(Evento events in this.eventi)
            {
                Console.Write("\t" + events.GetDataEvento().ToString("dd/MM/yyyy"));
                Console.Write(" - ");
                Console.WriteLine(events.GetTitolo());
            }
        }

        public int LunghezzaLista()
        {
            int lunghezzaDellaLista = this.eventi.Count;
            return lunghezzaDellaLista;
        }

        //SVUOTA LA LISTA
        public void ListaVuota()
        {
            this.eventi.Clear();
        }

    }
}
