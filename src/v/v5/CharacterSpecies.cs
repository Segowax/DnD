using Common.Interfaces;

namespace v5
{
    public class CharacterSpecies : ICharacterSpecies
    {
        public string Name => throw new NotImplementedException();

        public ICharacter AddCharacterSpecies(ICharacter character)
        {
            return character;
        }
    }
}
