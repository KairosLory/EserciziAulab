using Esercizio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    internal class SurvivalHorrorVideogame : Videogame
    {
        private string _mainCharacterName;
        private string _typeOfCombatSystem; // Lascio private senza accesso in quanto non si modifica più avanti.
        private int _durationStory; // Lascio private senza accesso in quanto non si modifica più avanti.
        private bool _hasJumpScare; // Lascio private senza accesso in quanto non si modifica più avanti.

        public string MainCharacterName { get; set; } 

        public SurvivalHorrorVideogame(string title, string authorName, string authorSurname, DateTime pubblicationDate, string mainCharacterName, string typeOfCombatSystem, int durationPrincipalStory, bool hasSecondaryQuests) : base(title, authorName, authorSurname, pubblicationDate)
        {
            MainCharacterName = mainCharacterName;
            _typeOfCombatSystem = typeOfCombatSystem;
            _durationStory = durationPrincipalStory;
            _hasJumpScare = hasSecondaryQuests;
        }

        public SurvivalHorrorVideogame(string title, string authorName, string authorSurname, string mainCharacterName, string typeOfCombatSystem, int durationPrincipalStory, bool hasSecondaryQuests) : base(title, authorName, authorSurname)
        {
            MainCharacterName = mainCharacterName;
            _typeOfCombatSystem = typeOfCombatSystem;
            _durationStory = durationPrincipalStory;
            _hasJumpScare = hasSecondaryQuests;
        }

        public SurvivalHorrorVideogame(string title, string mainCharacterName, string typeOfCombatSystem, int durationPrincipalStory, bool hasSecondaryQuests) : base(title)
        {
            MainCharacterName = mainCharacterName;
            _typeOfCombatSystem = typeOfCombatSystem;
            _durationStory = durationPrincipalStory;
            _hasJumpScare = hasSecondaryQuests;
        }

        public SurvivalHorrorVideogame()
        {
        }

    }
}
