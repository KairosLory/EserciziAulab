namespace EsercizioExtra1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO: Controllare se una stringa e' palindroma
            Console.WriteLine("Inserisci una stringa:");
            string userStringInput = Console.ReadLine().Trim().ToLower(); // Ho aggiunto sia Trim() che ToLower() per uniformare le risposte dell'utente.

            // Per verificare se una stringa generica è palindroma creerò una stringa al contrario e poi confronterò se le due stringhe sono uguali.

            // Per ampliare al caso di controllare intere frasi palindrome, ho deciso di rimuovere tutti gli spazi bianchi dalla frase inserita.
            // Dopodichè si ottiene una sola parola su cui viene semrpe effettuata la procedura di controllo se è palindroma o meno.
            string userStringInputComplete = string.Concat(userStringInput.Where(x => !char.IsWhiteSpace(x)));

            // 1) Ho utilizzato Reverse() dal LINQ per ottenere un IEnumerable<char> che ho poi trasformato in un array di char con ToArray().
            // 2) Ho poi utilizzato il costruttore di string per ricreare la stringa al contrario dando come parametro l'array di char.
            string userStringInputCompleteReversed = new string(userStringInputComplete.Reverse().ToArray());

            if(userStringInputComplete == userStringInputCompleteReversed)
            {
                Console.WriteLine("La stringa scritta è palindroma!");
            }
            else
            {
                Console.WriteLine("La stringa scritta NON è palindroma!");
            }

            Console.ReadLine(); // Utilizzato nel debugging per fermare l'esecuzione del programma.
        }
    }
}
