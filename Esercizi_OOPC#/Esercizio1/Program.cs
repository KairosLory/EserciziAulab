namespace Esercizio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESERCIZIO: Creare una classe, estenderla con almeno due sottoclassi.
            // Gestire le diverse tipologie di modificatori utilizzando getter e setter
            // Scrivere il metodo equals in modo da confrontare due oggetti della stessa classe

            // Ho fatto delle prove con ogni classe
            Videogame lookOutside = new Videogame("Look Outside", "Francis", "Coulombe");
            lookOutside.PubblicationDate = new DateTime(2024, 10, 24);

            SurvivalHorrorVideogame sluggyAdventure = new SurvivalHorrorVideogame("Sluggy Adventure", "Francis", "Coulumbe",
                                                                                  "SluggyQueen", "Turn Based", 10, true);
            sluggyAdventure.PubblicationDate = new DateTime(2022,9,12);

            RpgVideogame finalFantasyXVI = new RpgVideogame("Final Fantasy XVI", "Clive", "JRPG", 60, true);
            finalFantasyXVI.PubblicationDate = new DateTime(2023, 6, 2023);


            Console.ReadLine(); // Utilizzato nel debugging per fermare l'esecuzione del programma.
        }
    }
}
