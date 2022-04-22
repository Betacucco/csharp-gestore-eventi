using GestoreEventi;


Console.Write("Inserisci il nome dell'evento: ");
string nomeEvento = Console.ReadLine();

Console.Write("Inserisci data evento: ");
DateTime dataOra = DateTime.Parse(Console.ReadLine());

Console.Write("Inserisci la capienza massima: ");
int capienzaMassima = int.Parse(Console.ReadLine());

Evento concerto = new Evento (nomeEvento, dataOra, capienzaMassima);

Console.Write("Quanti posti desideri prenotare? ");
int numeroPostiDaPrenotare = int.Parse(Console.ReadLine());
concerto.PrenotaPosti(numeroPostiDaPrenotare);

Console.WriteLine();
Console.WriteLine("Numero di posti prenotati = " + concerto.GetNumeroPostiPrenotati());
Console.WriteLine("Numero di posti disponibili = " + (concerto.GetCapienzaMaxEvento() - concerto.GetNumeroPostiPrenotati()));
    
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
        Console.WriteLine("Numero di posti prenotati = " + concerto.DisdiciPosti(numeroPostiDaDisdire));
        Console.WriteLine("Numero di posti disponibili = " + (concerto.GetCapienzaMaxEvento() - concerto.GetNumeroPostiPrenotati()));
    } 
    else if (scelta == "no")
    {
        Console.WriteLine("Ok va bene!");
        flag = false;

        Console.WriteLine();
        Console.WriteLine("Numero di posti prenotati = " + concerto.GetNumeroPostiPrenotati());
        Console.WriteLine("Numero di posti disponibili = " + (concerto.GetCapienzaMaxEvento() - concerto.GetNumeroPostiPrenotati()));
    }
    else
    {
        Console.WriteLine("Non hai scelto si o no. Scegli!");
    }
}

    Console.Write("Inserisci il nome del tuo programma Eventi: ");
    string nomeProgrammaEventi = Console.ReadLine();
    Console.Write("Inserisci numero di eventi: ");
    int numeroEventi = int.Parse(Console.ReadLine());

    List<Evento> eventoList = new List<Evento>();

    for (int i = 0; i < numeroEventi; i++)
    {
        Console.Write("Inserisci il nome del " + (i+1) + " evento: ");
        string nomeEventoDaInserire = Console.ReadLine();

        Console.Write("Inserisci la data dell'evento: ");
        DateTime dataEvento = DateTime.Parse(Console.ReadLine());

        Console.Write("Inserisci numero di posti totali: ");
        int numeroPostiTotali = int.Parse(Console.ReadLine());

        Console.WriteLine();
        eventoList.Add(new Evento(nomeEventoDaInserire, dataEvento, numeroPostiTotali));
    }

    ProgrammaEventi lista = new ProgrammaEventi(nomeProgrammaEventi, eventoList);
    lista.Stampa();

    Console.WriteLine("Inserisci una data per sapee che eventi ci saranno: ");
    DateTime dataDaControllo = DateTime.Parse(Console.ReadLine());

    lista.StampaEventiGiornalieri(dataDaControllo);
