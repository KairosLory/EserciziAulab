using System.Numerics;

namespace Esercizio5
{
    internal class Program
    {
        static T[] BuildYourOwnArray<T>(int length) where T : INumber<T>
        {
            T[] yourArray = new T[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Inserisci il valore in posizione {i}");
                yourArray[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T)); // Per semplicità nell'esercizio non ho gestito il caso in cui l'utente possa inserire un dato diverso da quello che ha selezionato!
            }

            return yourArray;
        }
        // Messo il vincolo "INumber<T>" per permettere l'utilizzo del metodo "Convert.ToDouble" all'interno del ciclo.
        // Ho settato la sum double, in quanto è il tipo di dato più ampio tra quelli fra cui può scegliere l'utente.
        static void PrintSum<T>(T[] array) where T: INumber<T>
        {
            double sum = 0;

            foreach(var item in array)
            {
                sum += Convert.ToDouble(item);
            }

            Console.WriteLine("La somma di tutti gli elementi viene: " + sum); ;
        }
        static void Main(string[] args)
        {
            // ESERCIZIO: Creare un programma che chiede un numero all'utente per poi dichiarare un array con lunghezza pari al numero inserito.
            // Successivamente riempire l'array chiedendo quali numeri inserire all'utente per poi calcolarne la sommatoria.
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
                                "\nb) long" +
                                "\nc) float" +
                                "\nd) double");
                userChoice = Console.ReadLine().Trim().ToLower();
            }
            // Switch con annesso il metodo di stampa della somma degli elementi di ogni tipo di array.
            // Non ho aggiunto un "default" perchè tutte le casistiche vengono precedentemente gestite dai cicli while.
            switch (userChoice)
            {
                case "a":
                    int[] intArray = BuildYourOwnArray<int>(inputLenght);
                    PrintSum(intArray);
                    break;
                case "b":
                    long[] longArray = BuildYourOwnArray<long>(inputLenght);
                    PrintSum(longArray);
                    break;
                case "c":
                    float[] floatArray = BuildYourOwnArray<float>(inputLenght);   
                    PrintSum(floatArray);
                    break;
                case "d":
                    double[] doubleArray = BuildYourOwnArray<double>(inputLenght);
                    PrintSum(doubleArray);
                    break;
            }


            Console.ReadLine(); // Utilizzato nel debugging per fermare l'esecuzione del programma.
        }
    }
}
