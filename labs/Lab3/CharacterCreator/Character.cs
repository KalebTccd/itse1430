using System;

namespace CharacterCreator
{
    /// <summary>Represents a Character.</summary>
    public class Character
    {
        public Character ()
        { }
        #region Properties
        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get { return _name; }
            set { _name = value?.Trim() ?? ""; }
        }
        /// <summary>Gets or sets the profession.</summary>
        public string Profession
        {
            get { return _profession; }
            set { _profession = value?.Trim() ?? ""; }
        }
        /// <summary>Gets or sets the race.</summary>
        public string Race
        {
            get { return _race; }
            set { _race = value?.Trim() ?? ""; }
        }
        /// <summary>Gets or sets the biography.</summary>
        public string Biography
        {
            get { return _biography; }
            set { _biography = value?.Trim() ?? ""; }
        }
        /// <summary>Gets or sets the strength.</summary>
        public int Strength { get; set; }
        /// <summary>Gets or sets the intelligence.</summary>
        public int Intelligence { get; set; }
        /// <summary>Gets or sets the agility.</summary>
        public int Agility { get; set; }
        /// <summary>Gets or sets the constitution.</summary>
        public int Constitution { get; set; }
        /// <summary>Gets or sets the charisma.</summary>
        public int Charisma { get; set; }
        #endregion
        #region Fields
        private string _name;
        private string _profession;
        private string _race;
        private string _biography;
        #endregion

        #region Methods
        public bool Validate ( out string error )
        {
            //Name is required
            if (String.IsNullOrEmpty(Name))
            {
                error = "Name is required.";
                return false;
            };

            //Profssion within roles
            if (Profession != "Fighter" && Profession != "Hunter" && Profession != "Priest" && Profession != "Rogue" && Profession != "Wizard")
            {
                error = "That is not a valid option";
                return false;
            };

            //Race within roles
            if (Race != "Dwarf" && Race != "Elf" && Race != "Gnome" && Race != "Half Elf" && Race != "Human")
            {
                error = "That is not a valid option";
                return false;
            };

            // Strength < 0 || Strength > 100
            if (Strength < 0 || Strength > 100)
            {
                error = "Strength must be within 0 - 100";
                return false;
            };

            // Intelligence < 0 || Intelligence > 100
            if (Intelligence < 0 || Intelligence > 100)
            {
                error = "Intelligence must be within 0 - 100";
                return false;
            };

            // Agility < 0 || Agility > 100
            if (Agility < 0 || Agility > 100)
            {
                error = "Agility must be within 0 - 100";
                return false;
            };

            // Constitution < 0 || Constitution > 100
            if (Constitution < 0 || Constitution > 100)
            {
                error = "Constitution must be within 0 - 100";
                return false;
            };

            // Charisma < 0 || Charisma > 100
            if (Charisma < 0 || Charisma > 100)
            {
                error = "Charisma must be within 0 - 100";
                return false;
            };


            error = "";
            return true;
        }
        #endregion
    }
}
