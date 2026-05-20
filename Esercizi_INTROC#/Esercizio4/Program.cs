namespace Esercizio4
{
    internal class Program
    {
        static T[] BuildYourOwnArray<T>(int length) where T : IComparable<T>
        {
            T[] yourArray = new T[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Inserisci il valore in posizione {i}");
                yourArray[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T)); // Per semplicità nell'esercizio non ho gestito il caso in cui l'utente possa inserire un dato diverso da quello che ha selezionato!
            }

            return yourArray;
        }
        // Metodo che stampa il valore maggiore in un array di qualsiasi tipo di dato.
        // Il vincolo "where T : IComparable<T>" è necessario per poter utilizzare il metodo "CompareTo" e confrontare i valori all'interno dell'array senza un riferimento diretto al proprio tipo di dato.
        static void PrintMaxValue<T>(T[] array) where T : IComparable<T>
        {
            T maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(maxValue) > 0) // CompareTo restituisce un valore maggiore di 0 se "array[i]" è maggiore di "maxValue", 0 se sono uguali e un valore minore di 0 se "array[i]" è minore di "maxValue".
                {
                    maxValue = array[i];
                }
            }
            Console.WriteLine($"Il valore maggiore nell'array e': {maxValue}");
        }
        static void Main(string[] args)
        {
            // ESERCIZIO: Creare un programma che stampi l'elemento maggiore in un array.
            int inputLenght; // Variabile che conterrà la lunghezza dell'array desiderata dall'utente. Viene dichiarata qui per essere utilizzata anche al di fuori del ciclo "while" sottostante.

            Console.WriteLine("Quanti elementi vuoi nel tuo array?");
            string inputLenghtString = Console.ReadLine().Trim();
            // Controllo che l'input dell'utente sia un numero intero e strettamente maggiore di 0. In questo modo si evitano array vuoti.
            while (!int.TryParse(inputLenghtString, out inputLenght) || inputLenght <= 0)
            {
                Console.WriteLine("Il valore inserito non e' un numero intero positivo!\nQuanti elementi vuoi nel tuo array?");
                inputLenghtString = Console.ReadLine().Trim();
            }
            // Scelta lasciata all'utente sul tipo di dati che vuole inserire nell'array.
            Console.WriteLine("Seleziona di che tipo vuoi i valori nell'array:" +
                                "\na) int" +
                                "\nb) float" +
                                "\nc) double" +
                                "\nd) string");
            string userChoice = Console.ReadLine().Trim().ToLower();
            // Controllo che l'input dell'utente ricada nelle quattro opzioni disponibili.
            while (userChoice != "a" && userChoice != "b" && userChoice != "c" && userChoice != "d")
            {
                Console.WriteLine("Scelta non valida!\nSeleziona di che tipo vai i valori nell'array:" +
                                "\na) int" +
                                "\nb) float" +
                                "\nc) double" +
                                "\nd) string");
                userChoice = Console.ReadLine().Trim().ToLower();
            }
            // Switch con annesso il metodo di stampa del valore maggiore nell'array. Non ho aggiunto un "default" perchè tutte le casistiche vengono precedentemente gestite dai cicli while.
            switch(userChoice)
            {
                case "a":
                    int[] intArray = BuildYourOwnArray<int>(inputLenght);
                    PrintMaxValue(intArray);
                    break;
                case "b":
                    float[] floatArray = BuildYourOwnArray<float>(inputLenght);
                    PrintMaxValue(floatArray);
                    break;
                case "c":
                    double[] doubleArray = BuildYourOwnArray<double>(inputLenght);
                    PrintMaxValue(doubleArray);
                    break;
                case "d":
                    string[] stringArray = BuildYourOwnArray<string>(inputLenght);
                    PrintMaxValue(stringArray);
                    break;
            }

            Console.ReadLine(); // Utilizzato nel debugging per fermare l'esecuzione del programma.
        }
    }
}
