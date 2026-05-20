namespace Esercizio1
{
    internal class Videogame
    {
        private string _title;
        private string _authorName;
        private string _authorSurname;
        private DateTime _pubblicationDate;

        public string Title { get => _title; set => _title = value; }
        public string AuthorName { get => _authorName; set => _authorName = value; }
        public string AuthorSurname { get => _authorSurname; set => _authorSurname = value; }

        public DateTime PubblicationDate
        {
            get => _pubblicationDate;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("La data di pubblicazione non può essere futura.");
                } else if(value.Year < 1952)
                {
                    throw new ArgumentException("La data di pubblicazione non può essere precedente al 1952, anno di uscita del primo videogioco (OXO).");
                }

                _pubblicationDate = value;
            }
        }

        public Videogame(string title, string authorName, string authorSurname, DateTime pubblicationDate)
        {
            _title = title;
            _authorName = authorName;
            _authorSurname = authorSurname;
            _pubblicationDate = pubblicationDate;
        }

        public Videogame(string title, string authorName, string authorSurname)
        {
            _title = title;
            _authorName = authorName;
            _authorSurname = authorSurname;
        }

        public Videogame(string title)
        {
            _title = title;
        }

        public Videogame()
        {
        }

    }

    internal class RpgVideogame : Videogame
    {
        private string _mainCharacterName;
        private string _typeOfCombatSystem;
        private int _durationPrincipalStory;
        private bool _hasSecondaryQuests;

        public RpgVideogame(string title, string authorName, string authorSurname, DateTime pubblicationDate, string typeOfCombatSystem, int durationPrincipalStory, bool hasSecondaryQuests) : base(title, authorName, authorSurname, pubblicationDate)
        {
            _typeOfCombatSystem = typeOfCombatSystem;
            _durationPrincipalStory = durationPrincipalStory;
            _hasSecondaryQuests = hasSecondaryQuests;
        }

        public RpgVideogame(string title, string authorName, string authorSurname, string typeOfCombatSystem, int durationPrincipalStory, bool hasSecondaryQuests) : base(title, authorName, authorSurname)
        {
            _typeOfCombatSystem = typeOfCombatSystem;
            _durationPrincipalStory = durationPrincipalStory;
            _hasSecondaryQuests = hasSecondaryQuests;
        }

        public RpgVideogame(string title, string mainCharacterName, string typeOfCombatSystem, int durationPrincipalStory, bool hasSecondaryQuests) : base(title)
        {
            _mainCharacterName = mainCharacterName;
            _typeOfCombatSystem = typeOfCombatSystem;
            _durationPrincipalStory = durationPrincipalStory;
            _hasSecondaryQuests = hasSecondaryQuests;
        }

        public RpgVideogame()
        {
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESERCIZIO: Creare una classe, estenderla con almeno due sottoclassi.

            Console.ReadLine(); // Utilizzato nel debugging per fermare l'esecuzione del programma.
        }
    }
}
