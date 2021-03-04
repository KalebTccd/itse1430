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
            set { _biography = value.Trim(); }
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
    }
}
