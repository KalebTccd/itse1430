using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    /// <summary>Represents a database of characters.</summary>
    public interface ICharacterRoster
    {
        /// <summary>Adds a movie to the database.</summary>
        /// <param name="character">The movie to add.</param>
        /// <returns>The added movie.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="character"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="character"/> is invalid.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="character"/>Movie is not unique.</exception>
        Character Add ( Character character, out string error );

        /// <summary>Gets all the characters.</summary>
        /// <returns>All Characters.</returns>
        IEnumerable<Character> GetAll ();
    }
}
