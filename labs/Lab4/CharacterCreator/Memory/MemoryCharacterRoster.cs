using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Memory
{
    public class MemoryCharacterRoster : ICharacterRoster
    {
        private List<Character> _roster = new List<Character>();
        public Character Add ( Character character, out string error )
        {
            if(character == null)
            {
                error = "Movie is null";
                return null;
            };
            if (!character.Validate(out error))
            {
                var errors = new ObjectValidator().TryValidate(character);
                if (errors.Count > 0)
                {
                    error = errors[0].ErrorMessage;
                    return null;
                };
            }
        }
    }
}
