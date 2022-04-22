using GestoreEventi;
List<Evento> listaEventi = new List<Evento>();

Console.Write("Inserisci nuemro di eventi: ");
int numeroEventi = int.Parse(Console.ReadLine());

for (int i = 0; i < numeroEventi; i++)
{
    Console.Write("Inserisci il nome dell'evento: ");
    string nomeEvento = Console.ReadLine();

    Console.Write("Inserisci data evento: ");
    DateTime dataOra = DateTime.Parse(Console.ReadLine());

    Console.Write("Inserisci la capienza massima: ");
    int capienzaMassima = int.Parse(Console.ReadLine());

    Console.Write("Quanti posti desideri prenotare? ");
    int numeroPostiDaPrenotare = int.Parse(Console.ReadLine());

    listaEventi.Add(new Evento(nomeEvento, dataOra, capienzaMassima, numeroPostiDaPrenotare));
}

foreach (Evento evento in listaEventi)
{
    Console.WriteLine();
    Console.WriteLine("Numero di posti prenotati = " + evento.GetNumeroPostiPrenotati());
    Console.WriteLine("Numero di posti disponibili = " + (evento.GetCapienzaMaxEvento() - evento.GetNumeroPostiPrenotati()));
    
    bool flag = true;
    while (flag)
    {
        Console.WriteLine();
        Console.Write("Vuoi disdire dei posti(si/no)? ");
        string scelta = Console.ReadLine();


        if (scelta == "si")
        {
            Console.Write("Inserisci numero di posti da disdire = ");
            int numeroPostiDaDisdire = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Numero di posti prenotati = " + evento.DisdiciPosti(numeroPostiDaDisdire));
            Console.WriteLine("Numero di posti disponibili = " + (evento.GetCapienzaMaxEvento() - evento.GetNumeroPostiPrenotati()));
        } else if (scelta == "no")
        {
            Console.WriteLine("Ok va bene!");
            flag = false;

            Console.WriteLine();
            Console.WriteLine("Numero di posti prenotati = " + evento.GetNumeroPostiPrenotati());
            Console.WriteLine("Numero di posti disponibili = " + (evento.GetCapienzaMaxEvento() - evento.GetNumeroPostiPrenotati()));
        } else
        {
            Console.WriteLine("Non hai scelto si o no. Scegli!");
        }
    }
}
