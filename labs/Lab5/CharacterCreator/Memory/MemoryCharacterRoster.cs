/*
 * Charcter Creator
 * ITSE 1430
 * Spring 2021
 * Kaleb Dreier
 */
using System;
using System.Collections.Generic;
using System.Linq;


namespace CharacterCreator.Memory
{
    public class MemoryCharacterRoster : ICharacterRoster
    {
        private List<Character> _roster = new List<Character>();
        private int _id;
        public Character Add ( Character character )
        {
            if (character == null)
                throw new ArgumentNullException(nameof(character));
            ObjectValidator.Validate(character);
            var existing = FindByName(character.Name);
            if (existing != null)
                throw new InvalidOperationException("Name must be unique.");
            character.Id = ++_id;
            _roster.Add(CloneCharacter(character));

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
        public void Update ( int id, Character character )
        {
            if (character == null)
                throw new ArgumentNullException(nameof(character));
            ObjectValidator.Validate(character);
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0.");
            var existing = FindByName(character.Name);
            if (existing != null && existing.Id != id)
                throw new InvalidOperationException("Name must be unique.");

            existing = FindById(id);
            if (existing == null)
                throw new ArgumentNullException("Id does not exist");

            CopyCharacter(existing, character);
        }
        public void Delete ( int id )
        { 
            var existing = FindById(id) ?? throw new Exception("Id not valid.");
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
