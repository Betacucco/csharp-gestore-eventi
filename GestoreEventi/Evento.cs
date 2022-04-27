using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        //ATTRIBUTI
        private string titolo;
        private DateTime dataEvento;
        private int capienzaMaxEvento;
        private int numeroPostiPrenotati;

        //COSTRUTTORE
        public Evento(string titolo, DateTime dataEvento, int capienzaMaxEvento)
        {
            SetTitolo(titolo);
            SetDataEvento(dataEvento);
            this.numeroPostiPrenotati = 0;
            if (capienzaMaxEvento < 1)
            {
                throw new Exception("La capienza non puo' essere 0 o negativa!");
            }
            this.capienzaMaxEvento = capienzaMaxEvento;

        }

        //-----------------GETTERS--------------------
        public string GetTitolo()
        {
            return titolo;
        }

        public DateTime GetDataEvento()
        {
            return dataEvento;
        }

        public int GetCapienzaMaxEvento()
        {
            return capienzaMaxEvento;
        }

        public int GetNumeroPostiPrenotati()
        {
            return numeroPostiPrenotati;
        }
        //---------------------------------------------

        //-------------SETTERS---------------------
        public void SetTitolo(string titolo)
        {
            if (titolo == null)
            {
                throw new ArgumentNullException("Titolo non inserito!");
            }
            else
            {
                this.titolo = titolo;
            }
        }

        public void SetDataEvento(DateTime data)
        {
            if (data <= DateTime.Now)
            {
                throw new InvalidDataException("La data inserita e' nel passato o oggi.");
            }
            else
            {
                this.dataEvento = data;
            }
        }
        //------------------------------------

        //Restituisce il numero di posti disponibili
        public int PostiDisponibili()
        {
            return this.capienzaMaxEvento - this.numeroPostiPrenotati;
        }

        //Metodo per aggiungere posti
        public void PrenotaPosti(int posti)
        {
            if (numeroPostiPrenotati + posti > capienzaMaxEvento)
            {
                throw new Exception("Non posso prenotare tutti questi posti");
            }

            if (this.dataEvento < DateTime.Now)
            {
                throw new Exception("L'evento è già passato");
            }

            numeroPostiPrenotati += posti;
        }

        //Metodo per togliere posti
        public void DidisciPosti(int posti)
        {
            if (numeroPostiPrenotati - posti <= 0)
            {
                throw new Exception("Non posso disdire tutti questi posti");
            }

            if (dataEvento < DateTime.Now)
            {
                throw new Exception("L'evento è già passato");
            }

            numeroPostiPrenotati -= posti;
        }

        //Override del metodo toString per stampare ogni appuntamento in lista
        public override string ToString()
        {
            string rappresentazioneInStringa = "";

            rappresentazioneInStringa += this.dataEvento.ToString("dd/MM/yyyy");
            rappresentazioneInStringa += " - ";
            rappresentazioneInStringa += this.titolo + "\n";

            return rappresentazioneInStringa;
        }
    }
}
