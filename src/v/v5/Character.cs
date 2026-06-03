using Common.Interfaces;

namespace v5
{
    public class Character : ICharacter
    {
        public string Name => throw new NotImplementedException();
        public ICharacterClass Class => throw new NotImplementedException();
        public ICharacterSpecies Species => throw new NotImplementedException();
    }
}
