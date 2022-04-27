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
        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();            
        }

        //GET
        public string GetTitoloProgramma()
        {
            return titolo;
        }

        //AGGIUNGI EVENTI ALLA LISTA
        public void AggiungiEventi(Evento evento)
        {
            eventi.Add(evento);
        }

        //STAMPA EVENTI CHE HANNO LO STESSO GIORNO NELLA LISTA 
        public List<Evento> EventiInData(DateTime dataDaControllare)
        {
            List<Evento> eventiSelezionati = new List<Evento>();
            foreach (Evento evento in this.eventi)
            {
                if(evento.GetDataEvento() == dataDaControllare)
                {                   
                    eventiSelezionati.Add(evento);
                }
            }
            return eventiSelezionati;
        }

        //STAMPA LA LISTA CON DATA ED EVENTO
        public static string StampaListaEventi(List<Evento> listaEventi)
        {
            string rappresentazione = "";
            foreach(Evento evento in listaEventi)
            {
                rappresentazione += evento.ToString() + "\n";
            }
            return rappresentazione;
        }

        //Restituisce la lista di eventi
        public string ListaEventiInStringa()
        {
            string stringaOutput = this.titolo + "\n";
            foreach (Evento evento in eventi) 
            {
                stringaOutput += "\t" + evento.ToString() + "\n";
            }
            return stringaOutput;
        }

        //RESTITUISCE LA LUNGHEZZA DELLA LISTA
        public int LunghezzaLista()
        {
            return eventi.Count;
        }

        //SVUOTA LA LISTA
        public void ListaVuota()
        {
            this.eventi.Clear();
        }

    }
}
