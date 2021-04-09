/*
 * Charcter Creator
 * ITSE 1430
 * Spring 2021
 * Kaleb Dreier
 */
using System;
using System.Collections.Generic;

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

        /// <summary>Updates an existing character.</summary>
        /// <param name="id">The ID of the character to update.</param>
        /// <param name="movie">The updated character.</param>
        /// <exception cref="Exception">Character does not exist.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than one.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="movie"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="movie"/> is invalid.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="movie"/>Character is not unique.</exception>
        void Update ( int id, Character character, out string error );

        /// <summary>Deletes a Character.</summary>
        /// <param name="id">The ID of the Character.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than one.</exception>
        void Delete ( int id, out string error );
    }
}
