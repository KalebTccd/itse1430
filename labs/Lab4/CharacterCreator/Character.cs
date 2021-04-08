using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator
{
    /// <summary>Represents a Character.</summary>
    public class Character : IValidatableObject
    {
        #region Properties
        /// <summary>A unique identifier for character</summary>
        public int Id { get; set; }
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
        private int _id;
        #endregion

        #region Methods
        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            var errors = new List<ValidationResult>();
            //Name is required
            if (String.IsNullOrEmpty(Name))
            {
                errors.Add(new ValidationResult("Name is required."));
            };

            //Profssion within roles
            if (Profession != "Fighter" && Profession != "Hunter" && Profession != "Priest" && Profession != "Rogue" && Profession != "Wizard")
            {
                errors.Add(new ValidationResult("That is not a valid option"));
            };

            //Race within roles
            if (Race != "Dwarf" && Race != "Elf" && Race != "Gnome" && Race != "Half Elf" && Race != "Human")
            {
                errors.Add(new ValidationResult("That is not a valid option"));
            };

            // Strength < 0 || Strength > 100
            if (Strength < 0 || Strength > 100)
            {
                errors.Add(new ValidationResult("Strength must be within 0 - 100"));
            };

            // Intelligence < 0 || Intelligence > 100
            if (Intelligence < 0 || Intelligence > 100)
            {
                errors.Add(new ValidationResult("Intelligence must be within 0 - 100"));
            };

            // Agility < 0 || Agility > 100
            if (Agility < 0 || Agility > 100)
            {
                errors.Add(new ValidationResult("Agility must be within 0 - 100"));
            };

            // Constitution < 0 || Constitution > 100
            if (Constitution < 0 || Constitution > 100)
            {
                errors.Add(new ValidationResult("Constitution must be within 0 - 100"));
            };

            // Charisma < 0 || Charisma > 100
            if (Charisma < 0 || Charisma > 100)
            {
                errors.Add(new ValidationResult("Charisma must be within 0 - 100"));
            };
            return errors;
        }
        #endregion
    }
}
