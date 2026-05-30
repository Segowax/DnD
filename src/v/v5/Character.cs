using Common.Interfaces;

namespace v5
{
    public class Character : ICharacter
    {
        public string Name => throw new NotImplementedException();

        public ICharacterClass CharacterClass => throw new NotImplementedException();

        public ICharacterRace CharacterRace => throw new NotImplementedException();
    }
}
