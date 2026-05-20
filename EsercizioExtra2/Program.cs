namespace EsercizioExtra2
{
    internal class Program
    {
        // Metodo che controlla se ci sono due vocali ripetute consecutivamente in una stringa.
        static bool HasConsecutiveVowels(string input, char[] vowels)
        {
            bool isConsecutiveVowels = false;

            for(int i= 0; i < input.Length - 1; i++)
            {
                if (vowels.Contains(input[i]) && vowels.Contains(input[i + 1])) // Ho usato Contains dal LINQ per verificare se la stringa contenesse due char consecutivi da vowels.
                {
                    isConsecutiveVowels = true;
                    break; // Se troviamo due vocali consecutive, possiamo interrompere il ciclo e restituire "true".
                }
            }

            return isConsecutiveVowels;
        }
        static void Main(string[] args)
        {
            // ESERCIZIO: Creare un programma che controlla se ci sono due vocali ripetute consecutivamente in una stringa
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Inserisci una stringa:");
            string userStringInput = Console.ReadLine().Trim().ToLower(); // Ho aggiunto sia Trim() che ToLower() per uniformare le risposte dell'utente.

            if(HasConsecutiveVowels(userStringInput, vowels))
            {
                Console.WriteLine("La stringa contiene due vocali consecutive.");
            }
            else
            {
                Console.WriteLine("La stringa non contiene due vocali consecutive.");
            }

            Console.ReadLine(); // Utilizzato nel debugging per fermare l'esecuzione del programma.
        }
    }
}
