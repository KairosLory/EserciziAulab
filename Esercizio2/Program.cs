namespace Esercizio2
{
    internal class Program
    {
        // Metodo per dare la possibilità all'utente di inserire quanti numeri vuole.
        static void InputIntegerNumbers(List<int> numberList)
        {
            bool continueToAdd = true;
            // Ciclo while che continua finchè l'utente vuole inserire numeri.
            while (continueToAdd)
            {
                // Inserimento dell'utente della stringa da verificare.
                Console.WriteLine("Inserisci un numero intero: ");
                string inputNumber = Console.ReadLine().Trim();
                // Controllo che la stringa inserita sia un numero intero.
                int validInputNumber;
                while (!int.TryParse(inputNumber, out validInputNumber))
                {
                    Console.WriteLine("Il valore inserito non e' un numero intero!\nInserisci un numero:");
                    inputNumber = Console.ReadLine().Trim();
                }
                numberList.Add(validInputNumber);
                // Chiedo all'utente se vuole andare avanti nell'inserimento di numeri interi.
                Console.WriteLine("Vuoi inserire altri numeri (Si/No)?:");
                string inputContinue = Console.ReadLine().Trim().ToLower(); // Trim + ToLowe per uniformare le rispsote per il programma.
                // Ciclo while per evitare che l'utente inserisca una risposta diversa da "Si" o "No".
                while (inputContinue != "si" && inputContinue != "no")
                {
                    Console.WriteLine("Non fare lo sciocchino! Vuoi inserire altri numeri (Si/No)?:");
                    inputContinue = Console.ReadLine().Trim().ToLower();
                }

                if (inputContinue == "no")
                {
                    continueToAdd = false;
                }
            }
        }
        static void Main(string[] args)
        {
            // ESERCIZIO: Creare un programma che calcoli la media dei numeri interi (pari e dispari) poi media dei pari e media dei dispari

            // Ho scelto il tipo nullable di double in quanto preferisco che in caso di mancanza di pari o dispari, non venga stampato 0.
            double? averageEvenNumbers = null;
            double? averageOddNumbers = null;
            // Come struttura dati ho scelto la List per gestire un numero arbitrario di interi.
            List<int> numbersList = new List<int>();
            // Ho messo il metodo con tipo di ritorno "void" approfittando del fatto che le List sono un tipo-riferimento, quindi modificabile all'interno del metodo stesso in quanto il metodo lavora sui "puntatori".
            InputIntegerNumbers(numbersList);
            // Ho usato il LINQ per calcolare le medie.
            // Nel caso delle medie pari e dispari, ho usato variabili nullable allocate fuori dallo scopo dell'if per evitare problemi di stampa del risultato nel caso in cui non ci siano numeri pari o dispari.
            var averageAllNumbers = numbersList.Average();
            if (numbersList.Any(x => x % 2 == 0))
            {
                averageEvenNumbers = numbersList.Where(x => x % 2 == 0).Average();
            } 
            if (numbersList.Any(x => x % 2 != 0))
            {
                averageOddNumbers = numbersList.Where(x => x % 2 != 0).Average();
            }

            Console.WriteLine(  $"La media di tutti i numeri viene: {averageAllNumbers}" +
                                $"\nLa media di tutti i numeri pari viene: {averageEvenNumbers}" +
                                $"\nLa media di tutti i numeri dispari viene: {averageOddNumbers}");

            Console.ReadLine(); // Utilizzato nel debugging per fermare l'esecuzione del programma.
        }
    }
}
