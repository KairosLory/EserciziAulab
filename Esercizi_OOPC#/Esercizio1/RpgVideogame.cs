namespace Esercizio1
{
    internal class RpgVideogame : Videogame
    {
        private string _mainCharacterName;
        private string _typeOfCombatSystem; // Lascio private senza accesso in quanto non si modifica più avanti.
        private int _durationPrincipalStory; // Lascio private senza accesso in quanto non si modifica più avanti.
        private bool _hasSecondaryQuests; // Lascio private senza accesso in quanto non si modifica più avanti.

        public string MainCharacterName { get; set; }

        public RpgVideogame(string title, string authorName, string authorSurname, DateTime pubblicationDate, string mainCharacterName, string typeOfCombatSystem, int durationPrincipalStory, bool hasSecondaryQuests) : base(title, authorName, authorSurname, pubblicationDate)
        {
            MainCharacterName = mainCharacterName;
            _typeOfCombatSystem = typeOfCombatSystem;
            _durationPrincipalStory = durationPrincipalStory;
            _hasSecondaryQuests = hasSecondaryQuests;
        }

        public RpgVideogame(string title, string authorName, string authorSurname, string mainCharacterName, string typeOfCombatSystem, int durationPrincipalStory, bool hasSecondaryQuests) : base(title, authorName, authorSurname)
        {
            MainCharacterName = mainCharacterName;
            _typeOfCombatSystem = typeOfCombatSystem;
            _durationPrincipalStory = durationPrincipalStory;
            _hasSecondaryQuests = hasSecondaryQuests;
        }

        public RpgVideogame(string title, string mainCharacterName, string typeOfCombatSystem, int durationPrincipalStory, bool hasSecondaryQuests) : base(title)
        {
            MainCharacterName = mainCharacterName;
            _typeOfCombatSystem = typeOfCombatSystem;
            _durationPrincipalStory = durationPrincipalStory;
            _hasSecondaryQuests = hasSecondaryQuests;
        }

        public RpgVideogame()
        {
        }

    }
}
