using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Conferenza : Evento
    {
        //Attributi
        private string relatore;
        private double prezzo;

        //Costruttore
        public Conferenza(string titolo, DateTime dataEvento, int capienzaMaxEvento, string relatore, double prezzo) : base(titolo, dataEvento, capienzaMaxEvento)
        {
            this.relatore = relatore;
            this.prezzo = prezzo;
        }

        //-----------GETTER------------------
        public string GetRelatore()
        {
            return relatore;
        }

        public string GetPrezzo()
        {
            return prezzo.ToString("0.00") + " euro";
        }
        //----------------------------

        //Override del metodo ToString presente in Eventi
        public override string ToString()
        {
            string rappresentazioneInStringa = base.ToString();

            rappresentazioneInStringa += this.relatore;
            rappresentazioneInStringa += " - ";
            rappresentazioneInStringa += GetPrezzo();

            return rappresentazioneInStringa;
        }
    }
}
