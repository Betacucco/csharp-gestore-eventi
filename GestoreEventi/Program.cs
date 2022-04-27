using GestoreEventi;

//--------------------MALESTONE 1 E 2 -----------------------------------------------
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
Console.WriteLine("Numero di posti disponibili = " + concerto.PostiDisponibili());
    
bool flag = false;
string risposta;

while (!flag)
{
    Console.WriteLine();
    Console.Write("Vuoi disdire dei posti (si/no)? ");
    risposta = Console.ReadLine();

    switch (risposta)
    {
        case "si":
            Console.Write("Indica il numero di posti da disdire: ");
            int postiDaDisdire = int.Parse(Console.ReadLine());
            try
            {
                concerto.DidisciPosti(postiDaDisdire);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "no":
            flag = true;
            Console.WriteLine("Ok va bene!");
            break;
    }
    Console.WriteLine();

    Console.WriteLine("Numero di posti prenotati = " + concerto.GetNumeroPostiPrenotati());
    Console.WriteLine("Numero di posti disponibili = " + concerto.PostiDisponibili());
}
//-----------------------------------------------------------------------------------------
//------------------------ MALESTONE 3 E 4-------------------------------------------------
Console.Write("Inserisci il nome del tuo programma Eventi: ");
string nomeProgrammaEventi = Console.ReadLine();

ProgrammaEventi mioProgrammaEventi = new ProgrammaEventi(nomeProgrammaEventi);

Console.Write("Inserisci numero di eventi: ");
int numeroEventi = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < numeroEventi; i++)
{
    try
    {
        Console.Write("Inserisci il nome del " + (i + 1) + " evento: ");
        string nomeEventoDaInserire = Console.ReadLine();

        Console.Write("Inserisci la data dell'evento: ");
        DateTime dataEvento = DateTime.Parse(Console.ReadLine());

        Console.Write("Inserisci numero di posti totali: ");
        int numeroPostiTotali = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Evento evento = new Evento(nomeEventoDaInserire, dataEvento, numeroPostiTotali);
        mioProgrammaEventi.AggiungiEventi(evento);
    } catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine();
Console.WriteLine("Il numero di eventi nel programma e': " + mioProgrammaEventi.LunghezzaLista());
Console.WriteLine("Ecco il tuo programma eventi: ");
Console.WriteLine(mioProgrammaEventi.ListaEventiInStringa());

Console.Write("Inserisci una data per sapee che eventi ci saranno: ");
DateTime dataDaControllo = DateTime.Parse(Console.ReadLine());

List<Evento> listaEventiInData = mioProgrammaEventi.EventiInData(dataDaControllo);
string rapprensentazioneInStringaEventi = ProgrammaEventi.StampaListaEventi(listaEventiInData);

Console.WriteLine(rapprensentazioneInStringaEventi);
 
mioProgrammaEventi.ListaVuota();

//-----------------------------------------------------------------------------------------

//-----------------------------------------BONUS-------------------------------------------
bool conferenzaAggiunta = false;

while (!conferenzaAggiunta)
{
    try
    {
        Console.WriteLine();
        Console.WriteLine("---- BONUS -----");
        Console.WriteLine();

        Console.WriteLine("Aggiungiamo anche un conferenza!");
        Console.Write("Inserisci il nome della conferenza: ");
        string titoloConferenza = Console.ReadLine();

        Console.Write("Inserisci la data del conferenza (gg/mm/yyyy): ");
        DateTime dataConferenza = DateTime.Parse(Console.ReadLine());

        Console.Write("Inserisci il numero di posti per la conferenza: ");
        int postiConferenza = int.Parse(Console.ReadLine());

        Console.Write("Inserisci il relatore della conferenza: ");
        string relatore = Console.ReadLine();

        Console.Write("Inserisci il prezzo del biglietto della conferenza: ");
        double prezzoBiglietto = double.Parse(Console.ReadLine());

        Conferenza conferenza = new Conferenza(titoloConferenza, dataConferenza, postiConferenza, relatore, prezzoBiglietto);
        mioProgrammaEventi.AggiungiEventi(conferenza);

        conferenzaAggiunta = true;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine();

Console.WriteLine("Ecco il tuo programma eventi con anche le Conferenze: ");
Console.WriteLine(mioProgrammaEventi.ListaEventiInStringa());




