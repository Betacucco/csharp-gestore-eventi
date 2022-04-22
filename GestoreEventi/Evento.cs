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
            this.capienzaMaxEvento = capienzaMaxEvento;
            this.numeroPostiPrenotati = 0;
        }

        //GETTERS
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

        //SETTERS
        public void SetTitolo(string titolo)
        {
            if (string.IsNullOrEmpty(titolo))
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
        //---------------------------------------------------

        //Metodo per aggiungere posti
        public int PrenotaPosti(int postiDaAggiugnere)
        {
            if (this.numeroPostiPrenotati >= this.capienzaMaxEvento || this.dataEvento <= DateTime.Now)
            {
                throw new Exception("I posti sono finiti o la data e' sbagliata!");
            } else
            {
                this.numeroPostiPrenotati += postiDaAggiugnere;
                return this.numeroPostiPrenotati;
            }
        }

        //Metodo per togliere posti
        public int DisdiciPosti(int postiDaTogliere)
        {
            if (this.numeroPostiPrenotati > 0 || this.dataEvento > DateTime.Now)
            {
                this.numeroPostiPrenotati -= postiDaTogliere;
                return this.numeroPostiPrenotati;
            } else
            {
                throw new Exception("Non puoi togliere posti perche' non ci sono o la data e' sbagliata!");
            }
        }

        //Override del metodo toString per stampare ogni appuntamento in lista
        public override string ToString()
        {
            string rappresentazioneInStringa = "";

            rappresentazioneInStringa += "Data Evento: " + this.dataEvento.ToString("dd/MM/yyyy");
            rappresentazioneInStringa += " - ";
            rappresentazioneInStringa += "Titolo evento: " + this.titolo + "\n";

            return rappresentazioneInStringa;
        }
    }
}
