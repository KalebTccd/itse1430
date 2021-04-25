/*
 * Charcter Creator
 * ITSE 1430
 * Spring 2021
 * Kaleb Dreier
 */
using System;
using System.Collections.Generic;


namespace CharacterCreator.Memory
{
    public class MemoryCharacterRoster : ICharacterRoster
    {
        private List<Character> _roster = new List<Character>();
        private int _id;
        public Character Add ( Character character, out string error )
        {
            if (character == null)
            {
                error = "Movie is null";
                return null;
            };
            var errors = new ObjectValidator().TryValidate(character);
            if (errors.Count > 0)
            {
                error = errors[0].ErrorMessage;
                return null;
            };
            var existing = FindByName(character.Name);
            if (existing != null)
            {
                error = "Name must be unique";
                return null;
            };
            character.Id = ++_id;
            _roster.Add(CloneCharacter(character));

            error = null;
            return character;
        }
        public IEnumerable<Character> GetAll ()
        {
            var items = new Character[_roster.Count];
            int index = 0;
            foreach (var item in _roster)
                items[index++] = CloneCharacter(item);
            return items;
        }
        public void Update ( int id, Character character, out string error )
        {
            if (character == null)
            {
                error = "Movie is null";
                return;
            };

            var errors = new ObjectValidator().TryValidate(character);
            if (errors.Count > 0)
            {
                error = errors[0].ErrorMessage;
                return;
            };

            if (id <= 0)
            {
                error = "Id must be greater than zero.";
                return;
            };

            var existing = FindByName(character.Name);
            if (existing != null && existing.Id != id)
            {
                error = "Movie title must be unique";
                return;
            };

            existing = FindById(id);
            if (existing == null)
            {
                error = "Movie does not exist";
                return;
            };

            error = null;

            CopyCharacter(existing, character);
        }
        public void Delete ( int id, out string error )
        {
            if (id <= 0)
            {
                error = "Id must be greater than zero.";
                return;
            };
            error = null;

            var existing = FindById(id);
            if (existing != null)
                _roster.Remove(existing);
        }
        private Character CloneCharacter ( Character character )
        {
            var target = new Character() {
                Id = character.Id
            };

            CopyCharacter(target, character);
            return target;
        }
        private void CopyCharacter ( Character target, Character source )
        {
            target.Name = source.Name;
            target.Profession = source.Profession;
            target.Race = source.Race;
            target.Biography = source.Biography;
            target.Strength = source.Strength;
            target.Intelligence = source.Intelligence;
            target.Agility = source.Agility;
            target.Constitution = source.Constitution;
            target.Charisma = source.Charisma;
        }
        private Character FindByName ( string name )
        {
            foreach (var item in _roster)
            {
                if (String.Compare(item.Name, name, true) == 0)
                    return item;
            };
            return null;
        }
        private Character FindById ( int id )
        {
            foreach (var item in _roster)
            {
                if (item.Id == id)
                    return item;
            };

            return null;
        }
    }
}
