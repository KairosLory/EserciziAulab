namespace Esercizio3
{
    internal class Program
    {
        // Metodo generico per costruire un array di qualsiasi tipo specificato dall'utente con annessa scelta della lunghezza dell'array.
        // Per non complicare l'esercizio non ho aggiunto alcun vincolo con "where".
        static T[] BuildYourOwnArray<T>(int length)
        {
            T[] yourArray = new T[length];
            
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"Inserisci il valore in posizione {i}");
                    yourArray[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                }

            return yourArray;
        }
        // Metodo generico che stampa solo gli elementi in posizione pari di un array di qualsiasi tipo.
        static void PrintEvenPositions<T>(T[] array)
        {
            int counter = 0; // Variabile usata come contatore nel foreach successivo.
            Console.WriteLine("Gli elementi in posizione pari sono:");

            foreach(var item in array)
            {
                if(counter % 2 == 0)
                {
                    Console.WriteLine(item);
                }

                counter++;
            }
        }
        static void Main(string[] args)
        {
            // ESERCIZIO: Creare un programma che stampi solo gli elementi in posizione pari di un array
            int inputLenght; // Variabile che conterrà la lunghezza dell'array desiderata dall'utente. Viene dichiarata qui per essere utilizzata anche al di fuori del ciclo "while" sottostante.

            Console.WriteLine("Quanti elementi vuoi nel tuo array?");
            string inputLenghtString = Console.ReadLine().Trim();
            // Controllo che l'input dell'utente sia un numero intero e strettamente maggiore di 0. In questo modo si evitano array vuoti.
            while(!int.TryParse(inputLenghtString, out inputLenght) || inputLenght <= 0)
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
            while(userChoice != "a" && userChoice != "b" && userChoice != "c" && userChoice != "d")
            {
                Console.WriteLine("Scelta non valida!\nSeleziona di che tipo vai i valori nell'array:" +
                                "\na) int" +
                                "\nb) float" +
                                "\nc) double" +
                                "\nd) string");
                userChoice = Console.ReadLine().Trim().ToLower();
            }
            // Switch con annesso il metodo di stampa degli elementi in posizione pari. Non ho aggiunto un "default" perchè tutte le casistiche vengono precedentemente gestite dai cicli while.
            switch (userChoice)
            {
                case "a":
                    int[] intArray = BuildYourOwnArray<int>(inputLenght);
                    PrintEvenPositions(intArray); //C# deduce che "int" è il tipo di "T" in "PrintEvenPositions" grazie al tipo dell'array passato come argomento.
                    break;
                case "b":
                    float[] floatArray = BuildYourOwnArray<float>(inputLenght);
                    PrintEvenPositions(floatArray);
                    break;
                case "c":
                    double[] doubleArray = BuildYourOwnArray<double>(inputLenght);
                    PrintEvenPositions(doubleArray);
                    break;
                case "d":
                    string[] stringArray = BuildYourOwnArray<string>(inputLenght);
                    PrintEvenPositions(stringArray);
                    break;
            }

            Console.ReadLine(); // Utilizzato nel debugging per fermare l'esecuzione del programma.
        }
    }
}
