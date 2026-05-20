namespace INTROC__EserciziAulab
{
    internal class Program
    {
        // Funzione che controlla se un numero intero è pari o dispari.
        static bool IsEvenOrOdd(int number)
        {
            if(number %2 == 0)
            {
                return true; 
            }

            return false;
        }
        static void Main(string[] args)
        {
            // ESERCIZIO: Creare un programma che controlla se un numero e' pari o dispari

            // Inserisco all'utente di inserire un numero. Utilizzo "Trim()" per evitare eventuali spazi bianchi nella stringa.
            Console.WriteLine("Inserisci un numero:");
            string inputNumber = Console.ReadLine().Trim();
            // Creo la variabile che conterrà il numero valido, in modo che "viva" anche al di fuori del ciclo "while" sottostante.
            int validInputNumber;

            // Ciclo while che controlla se inputNumber sia effettivamente un numero intero. Se non lo è, continua a chiedere finchè l'utente non inserisce un numero accettabile.
            while(!int.TryParse(inputNumber, out validInputNumber))
            {
                Console.WriteLine("Il valore inserito non e' un numero intero!\nInserisci un numero:");
                inputNumber = Console.ReadLine().Trim();
            }

            // Applico la funzione "IsEvenOrOdd" al numero valido inserito dall'utente e stampo se è pari o dispari.
            if (IsEvenOrOdd(validInputNumber))
            {
                Console.WriteLine($"Il numero {validInputNumber} e' pari!");
            }
            else
            {
                Console.WriteLine($"Il numero {validInputNumber} e' dispari!");
            }

            Console.ReadLine(); // Utilizzato nel debugging per fermare l'esecuzione del programma.
        }
    }
}
